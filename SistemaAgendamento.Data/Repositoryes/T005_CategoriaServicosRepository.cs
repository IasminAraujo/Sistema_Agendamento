using SistemaAgendamento.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaAgendamento.Data.Repositoryes
{
    public class T005_CategoriaServicosRepository : RepositoryBase<T005_CategoriaServicos>
    {
        public T005_CategoriaServicos GetCategoriaById(int id)
        {
            return TableContext.Where(x => x.A005_id.Equals(id)).FirstOrDefault();
        }
    }
}
