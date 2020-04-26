using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Model;
using Microsoft.AspNetCore.Http;
using eProdaja.Model.Requests;
using Microsoft.AspNetCore.Mvc;
using eProdaja.Services;

namespace eProdaja.Controllers
{
    public class ProizvodController :
        BaseCRUDController<Model.Proizvod, ProizvodiSearchRequest, ProizvodiInsertRequest, ProizvodUpdateRequest>
    {
        public ProizvodController(ICRUDService<Model.Proizvod, ProizvodiSearchRequest, ProizvodiInsertRequest, ProizvodUpdateRequest> service)
            : base(service)
        {

        }

    }
}
