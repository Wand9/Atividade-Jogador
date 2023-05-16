using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogador
{
    public abstract class JogadorFutebol
{
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Nacionalidade { get; set; }
    public float Altura { get; set; }
    public float Peso { get; set; }

    public abstract void ImprimirDados();

    public int CalcularIdade()
    {
        DateTime hoje = DateTime.Today;
        int idade = hoje.Year - DataNascimento.Year;
        if (hoje < DataNascimento.AddYears(idade))
        {
            idade--;
        }
        return idade;
    }

    public abstract int TempoAteAposentar();
}
}