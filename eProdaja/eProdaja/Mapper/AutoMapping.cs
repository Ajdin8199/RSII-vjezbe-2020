using AutoMapper;
using eProdaja.Model.Requests;
using eProdaja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Mappers
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Models.Korisnici, Model.Korisnici>(); 
            CreateMap<Models.KorisniciUloge, Model.KorisniciUloge>(); 
            CreateMap<Models.Uloge, Model.Uloge>();
            CreateMap<KorisniciInsertRequest, Models.Korisnici>(); 
            CreateMap<KorisniciUpdateRequest, Models.Korisnici>(); 
            CreateMap<VrsteProizvoda, Model.VrsteProizvoda>();
            CreateMap<JediniceMjere, Model.JediniceMjere>();
            CreateMap<Proizvodi, Model.Proizvod>();
            CreateMap<ProizvodiInsertRequest, Proizvodi>();
        }
    }
}