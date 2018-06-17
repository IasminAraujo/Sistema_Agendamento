using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SistemaAgendamento.Controllers
{
    public class CategoriaServicosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}