using Banco.Models;
using Banco.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Banco.Controllers
{
    public class ContaController : Controller
    {

        private UnitsOfWork _unit = new UnitsOfWork();


        public ActionResult Listar()
        {
            return View(_unit.ContaRepository.Listar());
        }


        [HttpPost]
        public ActionResult Cadastrar(Conta conta)
        {
            _unit.ContaRepository.Cadastrar(conta);
            _unit.Salvar();
            TempData["msg"] = "Conta Cadastrada com sucesso!";
            return RedirectToAction("Cadastrar");
        }


        // GET: Cnta
        [HttpGet]
        public ActionResult Cadastrar()
        {
            ViewBag.Clientes = new SelectList(_unit.ClienteRepository.Listar(), "clienteId", "nome");
            ViewBag.Contas = new SelectList(_unit.ContaRepository.Listar(), "contaId", "nome");
            //_unit.Salvar();
            return View();
        }






        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}