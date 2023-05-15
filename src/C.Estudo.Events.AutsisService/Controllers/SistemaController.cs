using C.Estudo.Events.AutsisService.Models;
using C.Estudo.Events.Domain.Entities;
using C.Estudo.Events.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace C.Estudo.Events.AutsisService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SistemaController : ControllerBase
    {
        private readonly IAutsisService _autsisService;

        public SistemaController(IAutsisService autsisService)
        {
            _autsisService = autsisService;
        }

        [HttpGet]
        public ActionResult<List<Autsis>> GetAll()
        {
            var autsisSistemas = _autsisService.GetAll();
            if (!autsisSistemas.Any())
                return NoContent();

            return Ok(autsisSistemas);
        }

        [HttpPost]
        public ActionResult<Autsis> Add([FromBody] AutsisViewModel autsisViewModel)
        {
            var autsis = new Autsis(autsisViewModel.Sistema);
            autsis.InserirFuncionalidades(autsisViewModel.Funcionalidades);
            var novoSistema = _autsisService.Add(autsis);

            return Ok(novoSistema);
        }

        [HttpDelete]
        public ActionResult<Autsis> DeleteAll()
        {
            _autsisService.DeleteAll();
            return Ok();
        }
    }
}