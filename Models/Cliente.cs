using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Models
{
    public class Cliente
    {
        public string nome{get; set;}
        public List<NotaDeVenda> notaDeVendas{get;set;}
    }
}