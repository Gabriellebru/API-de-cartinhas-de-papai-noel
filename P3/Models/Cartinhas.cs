using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P3.Models
{
    public class Cartinhas
    {
        public string NomeDaCrianca { get; set; }   
        public string Endereco { get; set; }
        public int Idade { get; set; }
        public string Texto { get; set; }
        public Cartinhas(string nome, string endereco, int idade,string texto)
        {
            NomeDaCrianca = nome;
            Endereco = endereco;
            Idade = idade;
            Texto = texto;
        }

    }
}
