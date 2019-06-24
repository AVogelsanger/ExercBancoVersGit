using Banco.Models;
using Banco.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Banco.Controllers
{
    public class TipoContaController : Controller
    {
        private UnitsOfWork _unit = new UnitsOfWork();

        
        public ActionResult Listar()
        {
            return View(_unit.TipoContaRepository.Listar());
        }

        [HttpPost]
        public ActionResult Cadastrar(TipoConta tipoConta)
        {
            _unit.TipoContaRepository.Cadastrar(tipoConta);
            _unit.Salvar();
            return RedirectToAction("Cadastrar");
        }

        // GET: TipoConta
        [HttpGet]
        public ActionResult Cadastrar()
        {
            ViewBag.Contas = new SelectList(_unit.ContaRepository.Listar(), "contaId", "nome");
            return View();
        }
    }
}