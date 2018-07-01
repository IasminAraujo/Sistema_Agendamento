using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaAgendamento.Data.Entities;
using SistemaAgendamento.Data.Repositoryes;

namespace SistemaAgendamento.Controllers
{
    public class ColaboradoresController : Controller
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
        public IActionResult Excluir()
        {
            return View();
        }

        public IActionResult GetColaboradores()
        {
            try
            {
                List<T003_Colaboradores> lista;
                using (var repository = new T003_ColaboradoresRepository())
                {
                    lista = repository.SelectAll();
                }
                var retorno = new List<T003_ColaboradoresModel>();
                foreach (var item in lista)
                {
                    retorno.Add(new T003_ColaboradoresModel
                    {
                        A003_id = item.A003_id,
                        A003_nome = item.A003_nome,
                        A003_email = item.A003_email,
                        A003_endereco = item.A003_endereco,
                        A003_telefone = item.A003_telefone
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
        public IActionResult GetColaboradorById(int id)
        {
            try
            {
                T003_Colaboradores colaborador;
                using (var repository = new T003_ColaboradoresRepository())
                {
                    colaborador = repository.Select(id);
                }
                var retorno = new T003_ColaboradoresModel()
                {
                    A003_id = colaborador.A003_id,
                    A003_nome = colaborador.A003_nome,
                    A003_email = colaborador.A003_email,
                    A003_endereco = colaborador.A003_endereco,
                    A003_telefone = colaborador.A003_telefone
                };
                return Json(retorno);
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }

        [HttpPost]
        public IActionResult AdicionaColaborador([FromBody] T003_Colaboradores dados)
        {
            try
            {
                using (var repository = new T003_ColaboradoresRepository())
                {
                    var colaborador = new T003_Colaboradores();
                    colaborador.A003_nome = dados.A003_nome;
                    colaborador.A003_email = dados.A003_email;
                    colaborador.A003_endereco = dados.A003_endereco;
                    colaborador.A003_telefone = dados.A003_telefone;
                    repository.Insert(colaborador);
                }
                return Json("sucesso");
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }

        [HttpPost]
        public ActionResult EditarColaborador([FromBody] T003_Colaboradores dados)
        {
            try
            {
                using (var repository = new T003_ColaboradoresRepository())
                {
                    var colaborador = repository.Select(dados.A003_id);
                    colaborador.A003_nome = dados.A003_nome;
                    colaborador.A003_telefone = dados.A003_telefone;
                    colaborador.A003_email = dados.A003_email;
                    colaborador.A003_endereco = dados.A003_endereco;
                    repository.Update(colaborador);
                }
                return Json("sucesso");
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }

        [HttpGet]
        public ActionResult ExcluirColaborador(int id)
        {
            try
            {
                using (var repository = new T003_ColaboradoresRepository())
                {
                    var colaborador = repository.Select(id);
                    repository.Delete(colaborador);
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
