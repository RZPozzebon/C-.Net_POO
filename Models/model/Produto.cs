using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Estudo_dotnet.Models.model
{
    [Table("Produtos")]
    public class Produto
    {
        public int ID { get; set; }
        public required string nomeProduto { get; set; }
        public decimal valorProduto { get; set; }
    }
}