using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] {
            new Evento() {
                Id = 1,
                Tema = "Angular e .Net Core",
                Local = "BH",
                Lote = "1 Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemUrl = "foto.png"
            },
            new Evento() {
                Id = 2,
                Tema = "Angular e .Net Core 7",
                Local = "SP",
                Lote = "4 Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemUrl = "foto2.png"
            }

        };

        public EventoController() { }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var evento = _evento.FirstOrDefault(e => e.Id == id);
            if(evento == null) return BadRequest("Id Não Encontrado");
            return Ok(evento) ;
        }
    }
}


