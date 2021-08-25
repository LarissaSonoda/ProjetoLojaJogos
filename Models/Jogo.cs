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

        [Display(Name = "Versão")]
        public string versao { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório!")]
        [Display(Name = "Desenvolvedor")]
        public string desenvolvedor { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório!")]
        [Display(Name = "Gênero")]
        public string genero { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório!")]
        [Display(Name = "Faixa Etária")]
        public int faixaetaria { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório!")]
        [Display(Name = "Plataforma")]
        public string plataforma { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório!")]
        [Display(Name = "Ano de lançamento")]
        public int dtlanc { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório!")]
        [Display(Name = "Sinopse")]
        public string desc { get; set; }
    }
}