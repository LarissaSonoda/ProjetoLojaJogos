using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProjetoLojaJogos.Models
{
    public class Cliente
    {
        [Required(ErrorMessage = "O campo é obrigatório!")]
        [Display(Name = "Nome do Cliente")]
        public string CliNome { get; set; }

        [Display(Name = "CPF")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage="Valor inválido" )]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string CliCPF { get; set; }

        [Required(ErrorMessage = "Data de nascimento obrigatória")]
        [Display(Name ="Data de Nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode= true)]
        public DateTime CliDtNasc {
            get
            {
                return this.cliDtNasc.HasValue ? this.cliDtNasc.Value : DateTime.Now;
            }
            set
            {
                this.cliDtNasc = value;
            }
        
        }
        private DateTime? cliDtNasc = null;

        [Display(Name = "E-mail")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage ="Email inválido")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string CliEmail { get; set; }

        [Display(Name = "Celular")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string CliCel { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string CliEndereco { get; set; }
       
    }
}