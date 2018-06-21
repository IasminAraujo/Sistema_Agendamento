using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaAgendamento.Data.Entities;
using SistemaAgendamento.Data.Repositoryes;

namespace SistemaAgendamento.Controllers
{
    public class ServicosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult GetServicos()
        {
            try
            {
                List<T006_Servicos> lista;
                using (var repository = new T006_ServicosRepository())
                {
                    lista = repository.SelectAll();
                }
                var retorno = new List<object>();
                foreach (var item in lista)
                {
                    retorno.Add(new
                    {
                        item.A005_id,
                        item.A006_id,
                        item.A006_nome,
                        item.A006_tempoduracao,
                        item.A006_valorsessao
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