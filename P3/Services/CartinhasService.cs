using P3.Models;
using P3.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P3.Services
{
    public class CartinhasService : ICartinhasService
    {
        private ICartinhasRepository _repository;

        public CartinhasService(ICartinhasRepository repository)
        {
            _repository = repository;
        }
        public Cartinhas BuscarCartinha(string nome, string cidade)
        {
            return _repository.BuscarCartinha(nome,cidade);
        }

        public string InserirCartinha(Cartinhas cartinha)
        {
            return _repository.InserirCartinha(cartinha);
        }
    }
}
