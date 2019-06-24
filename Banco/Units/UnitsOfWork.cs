using Banco.Persistence;
using Banco.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banco.Units
{
    public class UnitsOfWork : IDisposable
    {

        private BancoContext _context = new BancoContext();
        private IClienteRepository _clienteRepository;
        private IContaRepository _contaRepository;
        private ITipoContaRepository _tipoContaRepository;

        public IClienteRepository ClienteRepository
        {
            get
            {
                if (_clienteRepository == null)
                {
                    _clienteRepository = new ClienteRepository(_context);
                }
                return _clienteRepository;
            }
        }

        public IContaRepository ContaRepository
        {
            get
            {
                if(_contaRepository == null)
                {
                    _contaRepository = new ContaRepository(_context);
                }
                return _contaRepository;
            }
        }

        public ITipoContaRepository TipoContaRepository
        {
            get
            {
                if (_tipoContaRepository == null)
                {
                    _tipoContaRepository = new TipoContaRepository(_context);
                }
                return _tipoContaRepository;
            }
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}