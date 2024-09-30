using Act_4_2_7.Contracts;
using Act_4_2_7.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Controllers_Act_4_2_7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnoController : ControllerBase
    {
        private readonly ITurnoService _turnoService;
        public TurnoController(ITurnoService service)
        {
            this._turnoService = service;   
        }
        // GET: api/<TurnoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Proximamente..." };
        }

        // GET api/<TurnoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "Proximamente...";
        }

        // POST api/<TurnoController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TTurno turno)
        {
            return Ok(await _turnoService.Save(turno));
        }
    }
}
