using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogador
{
    public class Jogador
    {
        public string Nome;
        public DateTime Nascimento;
        public string Nacionalidade;
        public int Altura;
        public int Peso;
        public string InfoJogador(string Nome, DateTime Nascimento, string Nacionalidade, int Altura, int Peso)
        {
            Nome = nome;
            Nascimento = nascimento;
            Nacionalidade = nacionalidade;
            Altura = altura;
            Peso = peso;

            return@$"
            Informações do Jogador:
            Nome: {Nome}
            Data de nascimento: {Nascimento}
            Nacionalidade: {Nacionalidade}
            Altura: {Altura}
            Peso: {Peso}
            ";
        }

        

    }
}