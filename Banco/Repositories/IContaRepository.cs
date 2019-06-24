using Banco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Repositories
{
    public interface IContaRepository
    {
        void Cadastrar(Conta conta);
        void Atualizar(Conta conta);
        Conta BuscarPeloId(int contaId);
        void Remover(int contaId);
        IList<Conta> Listar();
        IList<Conta> BuscarPorQualquerCoisa(Expression<Func<Conta, bool>> predicate);
    }
}
