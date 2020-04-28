using AutoMapper;
using eProdaja.Model;
using eProdaja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class UlogeService : BaseService<Model.Uloge, object, Models.Uloge>
    {
        public UlogeService(eProdajaContext context, IMapper mapper) : base(context, mapper)
        {
        }

    }
}
