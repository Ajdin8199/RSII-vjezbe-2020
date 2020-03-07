using eProdaja.Model.Requests;
using eProdaja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public interface IKorisniciService
    {
        IList<Model.Korisnici> GetAll();

        Korisnici GetById(int Id);

        Model.Korisnici Insert(KorisniciInsertRequest korisnik);

        Korisnici Update(int Id, Korisnici korisnik);
    }
}
