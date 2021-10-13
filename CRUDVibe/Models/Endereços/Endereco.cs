using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CRUDVibe.Models.Endereços
{
    public class Endereco
    {
        public int enderecoId { get; set; }
        [StringLength(50)]
        public string logradouro { get; set; }
        [StringLength(5)]
        public string numero { get; set; }
        [StringLength(8)]
        public string cep { get; set; }
        [StringLength(30)]
        public string cidade { get; set;}
        [StringLength(30)]
        public string estado { get; set;}
        public virtual Pessoa pessoa { get; set;}
    }
}