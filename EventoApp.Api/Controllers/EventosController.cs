using EventoApp.Core.Data;
using EventoApp.Core.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EventoApp.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EventosController : ControllerBase
    {
        private readonly EventoContext _db;
        public EventosController(EventoContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_db.Eventos);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var evento = _db.Eventos.Find(id);
            if(evento == null)
            {
                return NotFound();
            }
            return Ok(evento);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Evento evento)
        {
            if(evento == null)
                return BadRequest();
            _db.Eventos.Add(evento);
            _db.SaveChanges();

            return Created($"eventos/{evento.Id}", evento);
        }

        
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Evento evento)
        {
            if (id != evento.Id)
                return BadRequest();

            _db.Eventos.Update(evento);
            _db.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var evento = _db.Eventos.Find(id);

            if(evento == null)
            {
                return NotFound();
            }

            _db.Eventos.Remove(evento);

            _db.SaveChanges();

            return NoContent();
        }
    }
}
