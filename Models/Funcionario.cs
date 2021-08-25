using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProjetoLojaJogos.Models
{
    public class Funcionario
    {
        public ushort CodFunc { get; set; }
        public string FuncNome { get; set; }
        public string FuncCPF { get; set; }
        public string FuncRG { get; set; }
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
           
    
    }
}