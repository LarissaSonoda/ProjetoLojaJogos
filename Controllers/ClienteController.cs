using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoLojaJogos.Models;

namespace ProjetoLojaJogos.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            var cliente = new Cliente();
            return View(cliente);
        }
        [HttpPost]
        public ActionResult Index(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                return View("ListarCliente", cliente);
            }
            return View(cliente);
        }
    }
}