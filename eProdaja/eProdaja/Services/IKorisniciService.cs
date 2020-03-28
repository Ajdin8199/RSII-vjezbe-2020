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
        IList<Model.Korisnici> GetAll(KorisniciSearchRequest request);
        Model.Korisnici GetById(int Id);
        Model.Korisnici Insert(KorisniciInsertRequest korisnik);
        Model.Korisnici Update(int Id, KorisniciUpdateRequest korisnik);
        Model.Korisnici Login(KorisniciLoginRequest r);
        Model.Korisnici Delete(int Id);
    }
}
