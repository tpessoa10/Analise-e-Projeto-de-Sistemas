using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Models
{
    public class PagamentoComCartao : TipoDePagamento
    {
        public int numeroDoCartao{get;set;}
        public string bandeira{get;set;}
    }
}