using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public DataContext Context { get; }

        public EventoController(DataContext context) {
            this.Context = context;
            
         }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return Context.Eventos;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var evento = Context.Eventos.FirstOrDefault(e => e.Id == id);
            if (evento == null) return BadRequest("Id Não Encontrado");
            return Ok(evento);
        }
    }
}


