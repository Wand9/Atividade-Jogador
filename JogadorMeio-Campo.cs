using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogador
{
    public class JogadorMeioCampo : JogadorFutebol
    {
        public override void ImprimirDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Data de Nascimento: " + DataNascimento.ToShortDateString());
            Console.WriteLine("Nacionalidade: " + Nacionalidade);
            Console.WriteLine("Altura: " + Altura);
            Console.WriteLine("Peso: " + Peso);
        }

        public override int TempoAteAposentar()
        {
            int idadeAtual = CalcularIdade();
            int tempoRestante = 38 - idadeAtual;
            return Math.Max(0, tempoRestante);
        }
    }

}