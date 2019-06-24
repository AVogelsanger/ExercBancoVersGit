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
    public class TipoContaRepository : ITipoContaRepository
    {
        private BancoContext _context;

        public TipoContaRepository(BancoContext context)
        {
            _context = context;
        }

        public void Atualizar(TipoConta tipoConta)
        {
            _context.Entry(tipoConta).State = EntityState.Modified;
        }

        public TipoConta BuscarPeloId(int tipoContaId)
        {
            return _context.TipoContas.Find(tipoContaId);
        }

        public IList<TipoConta> BuscarPorQualquerCoisa(Expression<Func<TipoConta, bool>> predicate)
        {
            return _context.TipoContas.Where(predicate).ToList();
        }

        public void Cadastrar(TipoConta tipoConta)
        {
            _context.TipoContas.Add(tipoConta);
        }

        public IList<TipoConta> Listar()
        {
            return _context.TipoContas.ToList();
        }

        public void Remover(int tipoContaId)
        {
            TipoConta tpConta = _context.TipoContas.Find(tipoContaId);
            _context.TipoContas.Remove(tpConta);
        }
    }
}