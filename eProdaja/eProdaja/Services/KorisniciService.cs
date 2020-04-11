using AutoMapper;
using eProdaja.Filters;
using eProdaja.Model.Requests;
using eProdaja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class KorisniciService : IKorisniciService
    {
        protected eProdajaContext _context;
        protected IMapper _mapper;

        public KorisniciService(eProdajaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IList<Model.Korisnici> GetAll(KorisniciSearchRequest searchRequest)
        {
            var query = _context.Korisnici.AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchRequest?.Ime))
            {
                query = query.Where(x => x.Ime == searchRequest.Ime);
            }

            if (!string.IsNullOrWhiteSpace(searchRequest?.Prezime))
            {
                query = query.Where(x => x.Prezime == searchRequest.Prezime);
            }

            return _mapper.Map<IList<Model.Korisnici>>(query.ToList());
        }

        public Model.Korisnici GetById(int Id)
        {
            var entity = _context.Korisnici.Find(Id);
            return _mapper.Map<Model.Korisnici>(entity);
        }

        public Model.Korisnici Insert(KorisniciInsertRequest r)
        {
            Korisnici entity = _mapper.Map<Models.Korisnici>(r);
            _context.Add(entity);

            if (r.Password != r.PasswordPotvrda)
            {
                throw new Exception("Potvrda i password se ne slažu");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, r.Password);

            _context.SaveChanges();

            foreach (var uloga in r.Uloge)
            {
                KorisniciUloge korisniciUloge = new KorisniciUloge();
                korisniciUloge.KorisnikId = entity.KorisnikId;
                korisniciUloge.UlogaId = uloga;
                korisniciUloge.DatumIzmjene = DateTime.Now;
                _context.KorisniciUloge.Add(korisniciUloge);
            }

            _context.SaveChanges();
            return _mapper.Map<Model.Korisnici>(entity);
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public Model.Korisnici Update(int Id, KorisniciUpdateRequest r)
        {
            // dobavljanje iz baze
            var entity = _context.Korisnici.Find(Id);
            // mapiranje dobavljenih kolona
            _mapper.Map(r, entity);

            _context.SaveChanges();

            foreach (var uloga in r.Uloge)
            {
                KorisniciUloge korisniciUloge = new KorisniciUloge();
                korisniciUloge.KorisnikId = entity.KorisnikId;
                korisniciUloge.UlogaId = uloga;
                korisniciUloge.DatumIzmjene = DateTime.Now;
                _context.KorisniciUloge.Add(korisniciUloge);
            }

            _context.SaveChanges();

            return _mapper.Map<Model.Korisnici>(entity);
        }

        public Model.Korisnici Delete(int Id)
        {
            var obj = _context.Korisnici.Find(Id);
            var entity = _mapper.Map<Model.Korisnici>(obj);
            _context.Korisnici.Remove(obj);
            _context.SaveChanges();
            return entity;
        }

        public Model.Korisnici Login(KorisniciLoginRequest r)
        {
            var entity = _context.Korisnici.FirstOrDefault(x => x.KorisnickoIme == r.Username);

            if (entity == null)
            {
                throw new UserException("Pogresan username ili password");
            }

            var hash = GenerateHash(entity.LozinkaSalt, r.Password);

            if (hash != entity.LozinkaHash)
            {
                throw new UserException("Pogresan username ili password");
            }
            return _mapper.Map<Model.Korisnici>(entity);
        }
    }
}
