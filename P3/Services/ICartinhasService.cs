using P3.Models;
using P3.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P3.Services
{
    public interface ICartinhasService 
    {
        public string InserirCartinha(Cartinhas cartinha);

        public Cartinhas BuscarCartinha(string nome, string cidade);

    }
}
