﻿using System;
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
                var retorno = new List<T006_ServicosModel>();
                foreach (var item in lista)
                {
                    retorno.Add(new T006_ServicosModel
                    {
                        A005_nomecategoria = GetCategoria(item.A005_id),
                        A006_nome = item.A006_nome,
                        A006_valorsessao = item.A006_valorsessao,
                        A006_tempoduracao = item.A006_tempoduracao
                    });
                }

                return Json(retorno);
            }
            catch (Exception e)
            {

                return Json(e.Message);
            }
        }

        [HttpPost]
        public IActionResult AdicionaServico([FromBody] T006_Servicos dados)
        {
            try
            {
                using (var repository = new T006_ServicosRepository())
                {
                    var servico = new T006_Servicos();
                    servico.A006_nome = dados.A006_nome;
                    servico.A006_tempoduracao = dados.A006_tempoduracao;
                    servico.A006_valorsessao = dados.A006_valorsessao;
                    servico.A005_id = dados.A005_id;
                    repository.Insert(servico);
                }
                return Json("sucesso");
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
    }
}