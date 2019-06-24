using Banco.Models;
using Banco.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Banco.Controllers
{
    public class ClienteController : Controller
    {

        private UnitsOfWork _unit = new UnitsOfWork();


        public ActionResult Listar()
        {
            return View(_unit.ClienteRepository.Listar());
        }


        [HttpPost]
        public ActionResult Cadastrar(Cliente cliente)
        {
            _unit.ClienteRepository.Cadastrar(cliente);
            _unit.Salvar();
            TempData["msg"] = "Cliente cadastrado com sucesso!";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }




        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}