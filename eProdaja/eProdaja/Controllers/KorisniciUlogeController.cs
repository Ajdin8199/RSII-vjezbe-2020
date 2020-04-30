using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Model.Requests;
using eProdaja.Services;
using eProdaja.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [Authorize]
    [Route("api")]
    [ApiController]
    public class KorisniciUlogeController : ControllerBase
    {
        private readonly IKorisniciUlogeService _service;
        public KorisniciUlogeController(IKorisniciUlogeService service)
        {
            _service = service;
        }

        [HttpGet("Uloga/{Id}/Korisnici")]
        public List<Model.Korisnici> Get(int Id)
        {
            return _service.Get(Id);
        }
    }
}