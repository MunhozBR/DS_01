using Microsoft.AspNetCore.Mvc;
using OBJ_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBJ_01.Controllers
{
    public class ProdutoController : Controller
    {
        public static List<Produto> lsProduto = new List<Produto>();

        public IActionResult Index()
        {
            return View(lsProduto);
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult salvar(Produto item)
        {
            lsProduto.Add(item);
            return RedirectToAction("index");
        }
    }
}
