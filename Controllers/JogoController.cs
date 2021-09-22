using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoLojaJogos.Models;
using ProjetoLojaJogos.Repositorio;

namespace ProjetoLojaJogos.Controllers
{
    public class JogoController : Controller
    {
        // GET: Jogo
        public ActionResult Jogo()
        {
            var jogo = new Jogo();
            return View(jogo);
        }
       Acoes ac = new Acoes();

        [HttpPost]
        public ActionResult Jogo(Jogo jogo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ac.CadastrarJogo(jogo);
                    return RedirectToAction("ListarJogo");
                }
                return View(jogo);
            }
            catch
            {
                return RedirectToAction("Jogo");
            }
        }
        
        public ActionResult ListarJogo()
        {
            var ExibirJogo = new Acoes();
            var TodosJogo = ExibirJogo.ListarJogo();
            return View(TodosJogo);
        }

    }
}
