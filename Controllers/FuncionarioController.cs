using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoLojaJogos.Models;
using ProjetoLojaJogos.Repositorio;

namespace ProjetoLojaJogos.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Funcionario()
        {
            var funcionario = new Funcionario();
            return View(funcionario);
        }
        Acoes ac = new Acoes();

        [HttpPost]
        public ActionResult Funcionario(Funcionario funcionario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ac.CadastrarFunc(funcionario);
                    return RedirectToAction("ListarFuncionario");
                }
                return View(funcionario);
            }
            catch
            {
                return RedirectToAction("Funcionario");
            }
        }

        public ActionResult ListarFuncionario()
        {
            var ExibirFunc = new Acoes();
            var TodosFuncionarios = ExibirFunc.ListarFuncionario();
            return View(TodosFuncionarios);
        }
    }
}