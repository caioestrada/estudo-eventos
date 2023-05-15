using C.Estudo.Events.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace C.Estudo.Events.EmailService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly ICacheService _cacheService;

        public EmailController(ICacheService cacheService)
        {
            _cacheService = cacheService;
        }

        [HttpGet]
        public ActionResult<List<object>> GetAll()
        {
            var chavesEmCache = _cacheService.GetKeys().ToList();
            if (!chavesEmCache.Any())
                return NoContent();

            var valoresDasChaves = new List<object>();
            chavesEmCache.ForEach(chave => valoresDasChaves.Add(new { Id = chave, Responsavel = _cacheService.GetKey(chave).ToString() }));

            return Ok(valoresDasChaves);
        }

        [HttpPost]
        public ActionResult Add([FromBody] string valor)
        {
            _cacheService.Set(Guid.NewGuid().ToString(), valor);
            return Ok();
        }
    }
}