using EventoApp.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace EventoApp.Core.Data;
public class EventoContext : DbContext
{
    public DbSet<Evento> Eventos { get; set; }
    public EventoContext(DbContextOptions<EventoContext> options) 
        : base(options)
    {

    }
}

