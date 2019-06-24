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
    public class ContaRepository : IContaRepository
    {
        private BancoContext _context;

        public ContaRepository(BancoContext context)
        {
            _context = context;
        }

        public void Atualizar(Conta conta)
        {
            _context.Entry(conta).State = EntityState.Modified;
        }

        public Conta BuscarPeloId(int contaId)
        {
            return _context.Contas.Find(contaId);
        }

        public IList<Conta> BuscarPorQualquerCoisa(Expression<Func<Conta, bool>> predicate)
        {
            return _context.Contas.Where(predicate).ToList();
        }

        public void Cadastrar(Conta conta)
        {
            _context.Contas.Add(conta);
        }

        public IList<Conta> Listar()
        {   
            return _context.Contas.Include("Cliente").ToList();
        }

        public void Remover(int contaId)
        {
            Conta conta = _context.Contas.Find(contaId);
            _context.Contas.Remove(conta);
        }
    }
}