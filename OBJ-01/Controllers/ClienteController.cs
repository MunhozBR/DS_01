using Microsoft.AspNetCore.Mvc;
using OBJ_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBJ_01.Controllers
{
    public class ClienteController : Controller
    {
        public static List<Cliente> lsCliente = new List<Cliente>();
       
        public IActionResult Index()
        {
            return View(lsCliente);
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult salvar(Cliente item)
        {
            lsCliente.Add(item);
            return RedirectToAction("index");
        }


    }
}
