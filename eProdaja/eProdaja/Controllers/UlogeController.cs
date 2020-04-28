using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UlogeController : BaseController<Model.Uloge,object>
    {
        public UlogeController(IService<Model.Uloge, object> service) : base(service)
        {

        }
    }
}
