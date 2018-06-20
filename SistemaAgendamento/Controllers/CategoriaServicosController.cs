using System;
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
        public IActionResult Editar()
        {
            return View();
        }

        [HttpGet]
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
                        A005_id = item.A005_id,
                        A005_nome = item.A005_nome,
                    });
                }

                return Json(retorno);
            }
            catch (Exception e)
            {

                return Json(e.Message);
            }
        }

        [HttpGet]
        public IActionResult GetCategoriaById(int id)
        {
            try
            {
                T005_CategoriaServicos categoria;
                using (var repository = new T005_CategoriaServicosRepository())
                {
                    categoria =repository.GetCategoriaById(id);
                }
                var retorno = new T005_CategoriaServicosModel()
                {
                    A005_nome = categoria.A005_nome
                };
                return Json(retorno);
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }

        [HttpPost]
        public IActionResult AdicionaCategoria([FromBody] T005_CategoriaServicos dados)
        {
            try
            {
                using (var repository = new T005_CategoriaServicosRepository())
                {
                    var categoria = new T005_CategoriaServicos();
                    categoria.A005_nome = dados.A005_nome;
                    repository.Insert(categoria);
                }
                return Json("sucesso");
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }

        [HttpPost]
        public ActionResult EditarCategoria([FromBody] T005_CategoriaServicos dados)
        {
            try
            {
                using (var repository = new T005_CategoriaServicosRepository())
                {
                    repository.Update(dados);
                }
                return Json("sucesso");
            }
            catch (Exception e)
            {

                return Json(e.Message);
            }
        }
    }
}