using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banco.Models
{
    public class TipoConta
    {
        public int tipoContaId { get; set; }
        public string nome { get; set; }
        //SALARIO, CORRENTE, POUPANCA

        //RELACIONAMENTO
        public Conta Conta { get; set; }
        public int contaId { get; set; }
    }
}