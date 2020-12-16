using P3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P3.Repositories
{
    public class CartinhasRepository : ICartinhasRepository
    {
        private List<Cartinhas> cartinhas = new List<Cartinhas>()
        {
            new Cartinhas("Jose", "Centro",6,"Querido papai Noel, estou de P3 e quero passar"),
            new Cartinhas("Maria", "Centro n 456",10,"Querido Papai Noel, quero uma Barbie")
        };
        public string InserirCartinha(Cartinhas cartinha)
        {
            cartinhas.Add(cartinha);
            return cartinha.NomeDaCrianca;
        }

        public Cartinhas BuscarCartinha(string nome, string cidade)
        {
            return cartinhas.Find(a => a.NomeDaCrianca == nome && a.Endereco == cidade);
        }
    }
}
