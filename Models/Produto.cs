using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Models
{
    public class Produto
    {
        public string Nome {get; set;}
        public string Descricao {get; set;}
        public int Quantidade {get; set;}
        public double Preco{get; set;}
        public Marca Marca{get;set;}
    }
}