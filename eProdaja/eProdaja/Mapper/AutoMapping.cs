using AutoMapper;
using eProdaja.Model.Requests;
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
            CreateMap<Models.Korisnici, Model.Korisnici>(); // means you want to map from User to UserDTO
            CreateMap<KorisniciInsertRequest, Models.Korisnici>(); // means you want to map from User to UserDTO
        }
    }
}