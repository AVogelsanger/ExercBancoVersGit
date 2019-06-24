using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Banco.Models;
using Banco.Persistence;
using System.Data.Entity;

namespace Banco.Repositories
{
    public class ClienteRepository : IClienteRepository
    {

        private BancoContext _context;

        public ClienteRepository(BancoContext context)
        {
            _context = context;
        }
        
        public void Atualizar(Cliente cliente)
        {
            _context.Entry(cliente).State = EntityState.Modified;
        }

        public Cliente BuscarPeloId(int clienteId)
        {
            return _context.Clientes.Find(clienteId);
        }

        public IList<Cliente> BuscarPorQualquerCoisa(Expression<Func<Cliente, bool>> predicate)
        {
            return _context.Clientes.Where(predicate).ToList();
        }

        public void Cadastrar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
        }

        public IList<Cliente> Listar()
        {
            return _context.Clientes.ToList();
        }

        public void Remover(int clienteId)
        {
            Cliente cliente = _context.Clientes.Find(clienteId);
            _context.Clientes.Remove(cliente);
        }
    }
}