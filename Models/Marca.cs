using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Models
{
    public class Marca
    {
        public string Nome {get; set;}
        public string Descricao {get; set;}
        public List<Produto> Produtos{get;set;}
    }
}