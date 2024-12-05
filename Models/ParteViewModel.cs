using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontApiPessoal.Models
{
    public class ParteViewModel
    {
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Tipo { get; set; } = string.Empty;  // Ex: "Cliente", "Fornecedor", "Advogado"
    public string DocumentoIdentidade { get; set; } = string.Empty; // RG, CPF, CNPJ, etc.
    public string Endereco { get; set; } = string.Empty;
    public string Telefone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public List<DocumentoViewModel> Documentos {get; set;} = new List<DocumentoViewModel>();

    public ContratoViewModel? Contrato {get; set;}
    }
}