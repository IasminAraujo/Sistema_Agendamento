﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SistemaAgendamento.Controllers
{
    public class PacoteServicosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}