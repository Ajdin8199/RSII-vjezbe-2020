using AutoMapper;
using eProdaja.Model;
using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Mapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Korisnici, Model.Korisnici>();
            CreateMap<KorisniciInsertRequest, Korisnici>();
        }
    }
}
