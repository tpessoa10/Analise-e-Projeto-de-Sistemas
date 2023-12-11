using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Models
{
    public class Marca
    {
        public string nome {get; set;}
        public string descricao {get; set;}
        public List<Produto> produtos{get;set;}
    }
}