using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banco.Models
{
    public class Transacao
    {
        public int transacaoId { get; set; }
        public double valor { get; set; }
        public TipoTransacao tipoTransacao { get; set; }
        
    }
}