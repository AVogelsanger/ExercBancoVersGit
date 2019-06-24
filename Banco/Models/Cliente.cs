using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Banco.Models
{
    public class Cliente
    {
        public int clienteId { get; set; }
        public string cpf { get; set; }
        public string nome { get; set; }
        [Display(Name = "Data de Nascimento")]
        public DateTime dataNascimento { get; set; }
        [Display(Name = "Data do Cadastro")]
        public DateTime dataCadastro { get; set; }
        public string endereco { get; set; }
        
        //Relacionamento
        public virtual IList<Conta> Contas { get; set; }
    }
}