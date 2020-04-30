using AutoMapper;
using eProdaja.Model;
using eProdaja.Model.Requests;
using eProdaja.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class KorisniciUlogeService : IKorisniciUlogeService
    {
        private readonly eProdajaContext _context;
        private readonly IMapper _mapper;
        public KorisniciUlogeService(eProdajaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Korisnici> Get(int UlogaId)
        {
            var q = _context.KorisniciUloge.AsQueryable();

            q = q.Where(x => x.UlogaId == UlogaId);
            var l = q.Select(x => x.Korisnik).ToList();
            
            return _mapper.Map<List<Model.Korisnici>>(l);
        }
    }
}
