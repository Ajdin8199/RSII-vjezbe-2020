using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Model.Requests;
using eProdaja.Models;
using eProdaja.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisniciController : ControllerBase
    {
        protected IKorisniciService _service;

        public KorisniciController(IKorisniciService korisniciService)
        {
            _service = korisniciService;
        }

        [HttpGet]
        public IList<Model.Korisnici> Get([FromQuery]KorisniciSearchRequest searchRequest)
        {
            return _service.GetAll(searchRequest);
        }

        [HttpGet("{Id}")]
        public Model.Korisnici GetById(int Id)
        {
            return _service.GetById(Id);
        }

        [HttpPost]
        public Model.Korisnici Post(KorisniciInsertRequest k)
        {
            return _service.Insert(k);
        }

        [HttpPut("{Id}")]
        public Model.Korisnici Update(int Id, [FromBody]KorisniciUpdateRequest r)
        {
            return _service.Update(Id, r);
        }

        [HttpPost("login")]
        public Model.Korisnici Login(KorisniciLoginRequest r)
        {
            return _service.Login(r);
        }
    }
}