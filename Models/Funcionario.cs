using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProjetoLojaJogos.Models
{
    public class Funcionario
    {
        [Display(Name ="Código")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public ushort CodFunc { get; set; }

        [Display(Name ="Nome")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string FuncNome { get; set; }

        [Display(Name="CPF")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string FuncCPF { get; set; }

        [Display(Name ="RG")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string FuncRG { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FuncDtNasc
        {
            get
            {
                return this.funcDtNasc.HasValue ? this.funcDtNasc.Value : DateTime.Now;
            }
            set
            {
                this.funcDtNasc = value;
            }
        }
            private DateTime? funcDtNasc = null;

        [Display(Name ="Endereço")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string FuncEndereco { get; set; }

        [Display(Name ="Celular")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string FuncCel { get; set; }

        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido")]
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string FuncEmail { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório!")]
        [Display(Name ="Cargo")]
        public string FuncCargo { get; set; }
    }
}