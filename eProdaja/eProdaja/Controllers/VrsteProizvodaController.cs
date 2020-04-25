using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    public class VrsteProizvodaController : BaseController<Model.VrsteProizvoda, object>
    {
        public VrsteProizvodaController(IService<Model.VrsteProizvoda,object> service) : base(service)
        {
        }

    }
}
