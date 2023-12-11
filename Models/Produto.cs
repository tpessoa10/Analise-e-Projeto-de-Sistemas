using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Models
{
    public class Produto
    {
        public string nome {get; set;}
        public string descricao {get; set;}
        public int quantidade {get; set;}
        public double preco{get; set;}
        public Marca marca{get;set;}
    }
}