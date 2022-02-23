using Microsoft.AspNetCore.Mvc;
using OBJ_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBJ_01.Controllers
{
    public class PessoaController : Controller
    {
        public static List<Pessoa> lsPeesoa = new List<Pessoa>();
       
        public IActionResult Index()
        {
            return View(lsPeesoa);
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult salvar(Pessoa item)
        {
            lsPeesoa.Add(item);
            return RedirectToAction("index");
        }


    }
}
