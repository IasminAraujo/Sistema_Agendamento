using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaAgendamento.Data.Entities;
using SistemaAgendamento.Data.Repositoryes;

namespace SistemaAgendamento.Controllers
{
    public class ClientesController : Controller
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

        public IActionResult Agendar()
        {
            return View();
        }

        public IActionResult GetClientes()
        {
            try
            {
                List<T004_Clientes> lista;
                using (var repository = new T004_ClientesRepository())
                {
                    lista = repository.SelectAll();
                }
                var retorno = new List<T004_ClientesModel>();
                foreach (var item in lista)
                {
                    retorno.Add(new T004_ClientesModel
                    {
                        A004_id = item.A004_id,
                        A004_nome = item.A004_nome,
                        A004_email = item.A004_email,
                        A004_endereco = item.A004_endereco,
                        A004_telefone = item.A004_telefone
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
        public IActionResult GetClienteById(int id)
        {
            try
            {
                T004_Clientes cliente;
                using (var repository = new T004_ClientesRepository())
                {
                    cliente = repository.Select(id);
                }
                var retorno = new T004_ClientesModel()
                {
                    A004_id = cliente.A004_id,
                    A004_nome = cliente.A004_nome,
                    A004_email = cliente.A004_email,
                    A004_endereco = cliente.A004_endereco,
                    A004_telefone = cliente.A004_telefone
                };
                return Json(retorno);
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }

        [HttpPost]
        public IActionResult AdicionaCliente([FromBody] T004_Clientes dados)
        {
            try
            {
                using (var repository = new T004_ClientesRepository())
                {
                    var cliente = new T004_Clientes();
                    cliente.A004_nome = dados.A004_nome;
                    cliente.A004_email = dados.A004_email;
                    cliente.A004_endereco = dados.A004_endereco;
                    cliente.A004_telefone = dados.A004_telefone;
                    repository.Insert(cliente);
                }
                return Json("sucesso");
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }

        [HttpPost]
        public ActionResult EditarCliente([FromBody] T004_Clientes dados)
        {
            try
            {
                using (var repository = new T004_ClientesRepository())
                {
                    var cliente = repository.Select(dados.A004_id);
                    cliente.A004_nome = dados.A004_nome;
                    cliente.A004_telefone = dados.A004_telefone;
                    cliente.A004_email = dados.A004_email;
                    cliente.A004_endereco = dados.A004_endereco;
                    repository.Update(cliente);
                }
                return Json("sucesso");
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }

        [HttpGet]
        public ActionResult ExcluirCliente(int id)
        {
            try
            {
                using (var repository = new T004_ClientesRepository())
                {
                    var cliente = repository.Select(id);
                    repository.Delete(cliente);
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