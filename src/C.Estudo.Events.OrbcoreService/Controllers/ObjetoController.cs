using C.Estudo.Events.Domain.Entities;
using C.Estudo.Events.Domain.Interfaces.Services;
using C.Estudo.Events.OrbcoreService.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace C.Estudo.Events.OrbcoreService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjetoController : ControllerBase
    {
        private readonly IOrbcoreService _orbcoreService;
        private readonly IOrbcorePublishService _orbcorePublishService;
        private readonly IResponsavelPublishService _responsavelPublishService;

        public ObjetoController(IOrbcoreService orbcoreService, IOrbcorePublishService orbcorePublishService, IResponsavelPublishService responsavelPublishService)
        {
            _orbcoreService = orbcoreService;
            _orbcorePublishService = orbcorePublishService;
            _responsavelPublishService = responsavelPublishService;
        }

        [HttpGet]
        public ActionResult<List<Orbcore>> GetAll()
        {
            var orbcoreObjetos = _orbcoreService.GetAll();
            if (!orbcoreObjetos.Any())
                return NoContent();

            return Ok(orbcoreObjetos);
        }

        [HttpPost]
        public ActionResult<Orbcore> Add([FromBody] OrbcoreViewModel orbcoreViewModel)
        {
            var orbcore = new Orbcore(orbcoreViewModel.Objeto, orbcoreViewModel.Responsavel);
            orbcore.InserirMetodos(orbcoreViewModel.Metodos);

            var novoObjeto = _orbcoreService.Add(orbcore);
            _orbcorePublishService.PublishEvent(novoObjeto);
            _responsavelPublishService.PublishEvent(novoObjeto.Responsavel);

            return Ok(novoObjeto);
        }

        [HttpDelete]
        public ActionResult<Orbcore> DeleteAll()
        {
            _orbcoreService.DeleteAll();
            return Ok();
        }
    }
}