﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaAgendamento.Data.Entities;
using SistemaAgendamento.Data.Repositoryes;

namespace SistemaAgendamento.Controllers
{
    public class CategoriaServicosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult GetCategorias()
        {
            try
            {
                List<T005_CategoriaServicos> lista;
                using(var repository = new T005_CategoriaServicosRepository())
                {
                    lista = repository.SelectAll();
                }
                var retorno = new List<object>();
                foreach (var item in lista)
                {
                    retorno.Add(new {
                        id = item.A005_id,
                        nome = item.A005_nome,
                    });
                }

                return Json(retorno);
            }
            catch (Exception e)
            {

                return Json(e.Message);
            }
        }
    }
}