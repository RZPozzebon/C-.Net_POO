using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Estudo_dotnet.Models.model
{
    [Table("Clientes")]
    public class Cliente : Pessoa
    {
        public string? CPF { get; set; }
        public string? CNPJ { get; set; }
        public string? ContatoTelefone { get; set; }
        public string? ContatoEmail { get; set; }
    }
}