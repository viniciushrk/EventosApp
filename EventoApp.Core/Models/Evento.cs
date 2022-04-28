using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoApp.Core.Models;
public class Evento
{
    public int Id { get; set; }

    [StringLength(255)]
    [Required]
    public string? Nome { get; set; }
    [StringLength(4000)]
    public string? Descricao { get; set; }
    public DateTimeOffset Inicio { get; set; }
    public DateTimeOffset Fim { get; set; }
    
    [StringLength(100)]
    public string? Situacao { get; set; }
}

