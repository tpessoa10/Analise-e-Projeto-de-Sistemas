using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Models
{
    public class NotaDeVenda
    {
        public DateTime data{get; set;}
        public bool tipo{get;set;}
        public Cliente cliente{get; set;}
        public Pagamento pagamento{get;set;}

        public void Cancelar(){
            //
        }

        public void Devolver(){

        }
    }
}