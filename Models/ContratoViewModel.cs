using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontApiPessoal.Models
{
    public class ContratoViewModel
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public string Status { get; set; } = string.Empty;
        public string Cliente { get; set; } = string.Empty;
        public string Prestador { get; set; } = string.Empty;
        public decimal Valor { get; set; }

        public ParteViewModel? Parte { get; set; }
        public int ParteId { get; set; }
    }
}