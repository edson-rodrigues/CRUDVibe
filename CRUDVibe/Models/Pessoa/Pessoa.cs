using CRUDVibe.Models.Endereços;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUDVibe.Models
{
    public class Pessoa
    {
        public int pessoaId { get; set; }
        [StringLength(30)]
        public string nome { get; set;}
        [StringLength(11)]
        public string cpf { get; set;}
        [StringLength(11)]
        public string telefone { get; set; }
        public string email { get; set;}
        public virtual Endereco endereco { get; set; }

    }
}