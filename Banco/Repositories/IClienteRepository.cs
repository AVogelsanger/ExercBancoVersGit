using Banco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Repositories
{
    public interface IClienteRepository
    {
        void Cadastrar(Cliente cliente);
        void Atualizar(Cliente cliente);
        Cliente BuscarPeloId(int clienteId);
        void Remover(int clienteId);
        IList<Cliente> Listar();
        IList<Cliente> BuscarPorQualquerCoisa(Expression<Func<Cliente, bool>>predicate);
    }
}
