using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banco.Models
{
    public class Conta
    {
        public int contaId { get; set; }
        public int agencia { get; set; }
        public int numeroConta { get; set; }
        public TipoConta tipoConta { get; set; }
        public double saldo { get; set; }

        //Relacionamento
        public Cliente Cliente { get; set; }
        public int clienteId { get; set; }

        public virtual IList<TipoConta> TiposDeContas { get; set; }
    }
}