using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ProjetoLojaJogos.Models
{
    public class Jogo
    {
        [Required(ErrorMessage = "O campo é obrigatório!")]
        [Display(Name = "Código do Jogo")]
        public int CodJogo { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório!")]
        [Display(Name = "Nome do Jogo")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório!")]
        [Display(Name = "Versão")]
        public string versao { get; set; }

        [Display(Name = "Desenvolvedor")]
        public string desenvolvedor { get; set; }

        [Display(Name = "Gênero")]
        public string genero { get; set; }

        [Display(Name = "Faixa Etária")]
        public int faixaetaria { get; set; }

        [Display(Name = "Plataforma")]
        public string plataforma { get; set; }

        [Display(Name = "Ano de lançamento")]
        public int dtlanc { get; set; }

        [Display(Name = "Sinopse")]
        public string desc { get; set; }
    }
}