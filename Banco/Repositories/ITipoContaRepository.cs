using Banco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Repositories
{
    public interface ITipoContaRepository
    {
        void Cadastrar(TipoConta tipoConta);
        void Atualizar(TipoConta tipoConta);
        TipoConta BuscarPeloId(int tipoContaId);
        void Remover(int tipoContaId);
        IList<TipoConta> Listar();
        IList<TipoConta> BuscarPorQualquerCoisa(Expression<Func<TipoConta, bool>> predicate);
    }
}
