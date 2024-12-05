using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontApiPessoal.Models
{
    public class DocumentoViewModel
    {
    public int Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Tipo { get; set; } = string.Empty; // Ex: "Procuradoria", "Petição Inicial"
    public DateTime DataCriacao { get; set; }
    public string Status { get; set; } = string.Empty;  // Ex: "Em andamento", "Concluído"
    public string Observacoes { get; set; } = string.Empty;
    public bool Assinado { get; set; }  // Indica se o documento foi assinado

    public int ParteId {get; set;}
    public ParteViewModel? Parte {get; set;}
    }
}