using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoLojaJogos.Models;

namespace ProjetoLojaJogos.Controllers
{
    public class JogoController : Controller
    {
        // GET: Jogo
        public ActionResult Index()
        {
            var jogo = new Jogo();
            return View(jogo);
        }
        [HttpPost]
        public ActionResult Index(Jogo jogo)
        {
            if (ModelState.IsValid)
            {
                return View("ListarJogo", jogo);
            }
            return View(jogo);
        }

    }
}
