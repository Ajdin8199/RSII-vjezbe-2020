using AutoMapper;
using eProdaja.Model.Requests;
using eProdaja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class ProizvodService : BaseCRUDService<Model.Proizvod, ProizvodiSearchRequest, ProizvodiInsertRequest, ProizvodUpdateRequest, Proizvodi>
    {
        public ProizvodService(eProdajaContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Proizvod> Get(ProizvodiSearchRequest search)
        {
            var query = _context.Set<Proizvodi>().AsQueryable();
            
            if(search?.VrstaId != null && search.VrstaId != 0)
            {
                query = query.Where(x => x.VrstaId == search.VrstaId);
            }
            
            if(search?.JedinicaMjereId != null && search.JedinicaMjereId != 0)
            {
                query = query.Where(x => x.JedinicaMjereId == search.JedinicaMjereId);
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Proizvod>>(list);
        }
    }
}
