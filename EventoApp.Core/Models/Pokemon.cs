using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoApp.Core.Models;
public class Pokemon
{
    public string Nome { get; set; }
    public string Especie { get; set; }
    public string Raridade { get; set; }
    public string Img { get; set; }
}

