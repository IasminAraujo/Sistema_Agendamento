using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SistemaAgendamento.Data.Repositoryes;

namespace SistemaAgendamento.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using (var repo = new T005_CategoriaServicosRepository())
            {
                var a = repo.SelectAll();
                var b = JsonConvert.SerializeObject(a, new JsonSerializerSettings { Formatting = Formatting.Indented, ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
                return Json(a);
            }
           // return View();
        }
    }
}