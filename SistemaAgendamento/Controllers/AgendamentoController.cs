using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaAgendamento.Data.Entities;
using SistemaAgendamento.Data.Repositoryes;
using SistemaAgendamento.Models;

namespace SistemaAgendamento.Controllers
{
    public class AgendamentoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAgendamentos()
        {
            try
            {
                List<T009_Agendamento> lista;
                using (var repository = new T009_AgendamentoRepository())
                {
                    lista = repository.SelectAll();
                }
                var retorno = new List<T009_AgendamentoModel>();
                foreach (var item in lista)
                {
                    retorno.Add(new T009_AgendamentoModel
                    {
                        A009_id = item.A009_id,
                        A009_dataDT = String.Format("{0:dd/MM/yyyy}", item.A009_data),
                        A003_nomecolaborador = GetColaboradores(item.A003_id),
                        A004_nomecliente = GetClientes(item.A004_id),
                        A005_nomecategoria = GetCategoria(item.A005_id),
                        A006_nomeservico = GetServico(item.A006_id)
                    });
                }

                return Json(retorno);
            }
            catch (Exception e)
            {

                return Json(e.Message);
            }
        }

        private string GetClientes(int id)
        {
            using (var repository = new T004_ClientesRepository())
            {
                return repository.Select(id).A004_nome;
            }
        }
        private string GetColaboradores(int id)
        {
            using (var repository = new T003_ColaboradoresRepository())
            {
                return repository.Select(id).A003_nome;
            }
        }
        private string GetServico(int id)
        {
            using (var repository = new T006_ServicosRepository())
            {
                return repository.Select(id).A006_nome;
            }
        }

        private string GetCategoria(int id)
        {
            using (var repository = new T005_CategoriaServicosRepository())
            {
                return repository.Select(id).A005_nome;
            }
        }

        [HttpPost]
        public IActionResult AgendarCliente([FromBody] T009_Agendamento dados)
        {
            try
            {
                using (var repository = new T009_AgendamentoRepository())
                {
                    var agendamento = new T009_Agendamento();
                    agendamento.A009_data = dados.A009_data;
                    agendamento.A003_id = dados.A003_id;
                    agendamento.A004_id = dados.A004_id;
                    agendamento.A005_id = dados.A005_id;
                    agendamento.A006_id = dados.A006_id;
                    repository.Insert(agendamento);
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