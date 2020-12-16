using P3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P3.Repositories
{
    public interface ICartinhasRepository
    {
        public Cartinhas BuscarCartinha(string nome,string cidade);
        public string InserirCartinha(Cartinhas cartinha);
    }
}
