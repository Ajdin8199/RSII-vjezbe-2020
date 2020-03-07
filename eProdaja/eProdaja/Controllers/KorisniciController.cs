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
        public IList<Model.Korisnici> Get()
        {
            return _service.GetAll();
        }

        [HttpPost]
        public Model.Korisnici Post(KorisniciInsertRequest k)
        {
            return _service.Insert(k);
        }
    }
}