using eProdaja.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Models
{
    public partial class eProdajaContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JediniceMjere>().HasData(new eProdaja.Models.JediniceMjere()
            {
                JedinicaMjereId = 1,
                Naziv = "Test"
            });

            Korisnici testUser = new eProdaja.Models.Korisnici()
            {
                Ime = "test",
                Prezime = "test",
                Email = "test@gmail.com",
                Status = true,
                KorisnickoIme = "test",
                LozinkaSalt = GenerateSalt(),
                Telefon = "123456789"
            };
            testUser.LozinkaHash = GenerateHash(testUser.LozinkaSalt, "test");
            
            modelBuilder.Entity<Korisnici>().HasData(testUser);
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
    }
}
