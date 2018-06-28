using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaAgendamento.Data.Entities;
using SistemaAgendamento.Data.Repositoryes;

namespace SistemaAgendamento.Controllers
{
    public class PacoteServicosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult GetPacotes()
        {
            try
            {
                List<T007_PacoteServicos> lista;
                using (var repository = new T007_PacoteServicosRepository())
                {
                    lista = repository.SelectAll();
                }
                var retorno = new List<T007_PacoteServicosModel>();
                foreach (var item in lista)
                {
                    retorno.Add(new T007_PacoteServicosModel
                    {
                        A007_id = item.A007_id,
                        A007_quantsessao = item.A007_quantsessao,
                        A007_valorpacote = item.A007_valorpacote,
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
        private string GetCategoria(int id)
        {
            using (var repository = new T005_CategoriaServicosRepository())
            {
                return repository.Select(id).A005_nome;
            }
        }
        private string GetServico(int id)
        {
            using (var repository = new T006_ServicosRepository())
            {
                return repository.Select(id).A006_nome;
            }
        }
        [HttpPost]
        public IActionResult AdicionaPacote([FromBody] T007_PacoteServicos dados)
        {
            try
            {
                using (var repository = new T007_PacoteServicosRepository())
                {
                    var pacote = new T007_PacoteServicos();
                    pacote.A007_quantsessao = dados.A007_quantsessao;
                    pacote.A007_valorpacote = dados.A007_valorpacote;
                    pacote.A005_id = dados.A005_id;
                    pacote.A006_id = dados.A006_id;
                    repository.Insert(pacote);
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