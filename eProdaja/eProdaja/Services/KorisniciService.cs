using AutoMapper;
using eProdaja.Model.Requests;
using eProdaja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public IList<Model.Korisnici> GetAll()
        {
            IList<Korisnici> entitiys = _context.Korisnici.ToList();
            //IList<Model.Korisnici> result = new List<Model.Korisnici>();
            //entitiys.ForEach(x => result.Add(new Model.Korisnici()
            //{
            //    Email = x.Email,
            //    Ime = x.Ime,
            //    Prezime = x.Prezime,
            //    KorisnikId = x.KorisnikId,
            //    KorisnickoIme = x.KorisnickoIme,
            //    Status = x.Status,
            //    Telefon = x.Telefon
            //}));

            var result = _mapper.Map<IList<Model.Korisnici>>(entitiys);

            return result;
        }

        public Korisnici GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Model.Korisnici Insert(KorisniciInsertRequest r)
        {
            var entity = _mapper.Map<Korisnici>(r);
            _context.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Korisnici>(r);
        }

        public Korisnici Update(int Id, Korisnici korisnik)
        {
            throw new NotImplementedException();
        }
    }
}
