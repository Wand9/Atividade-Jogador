// 1.Crie uma classe abstrata para representar um jogador de futebol, com os atributos nome, data de nascimento, nacionalidade, altura e peso.

// Crie um método para imprimir todos os dados do jogador.

//Crie um método para calcular a idade do jogador e outro método para mostrar quanto tempo falta para o jogador se aposentar. 

//Para isso, crie outras 3 subclasses, JOGADORDEFESA, JOGADORATAQUE e JOGADORMEIO-CAMPO considere que os jogadores da posição de defesa se aposentam em média aos 40 anos, os jogadores de meio-campo aos 38 e os atacantes aos 35.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(@$"
        ----------------------------------------
        |                                      |
        |   Informe os dados do seu jogador:   |
        |                                      |
        ----------------------------------------
        ");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Data de Nascimento: ");
        DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

        Console.Write("Nacionalidade: ");
        string nacionalidade = Console.ReadLine();

        Console.Write("Altura: ");
        float altura = float.Parse(Console.ReadLine());

        Console.Write("Peso: ");
        float peso = float.Parse(Console.ReadLine());

        Console.WriteLine(@$"
        _______________________________________
       |                                       |
       | Informe a posição que o jogador joga: |
       |_______________________________________|

        ");
        Console.WriteLine("1. Defesa");
        Console.WriteLine("2. Ataque");
        Console.WriteLine("3. Meio-Campo");
        Console.Write("Opção: ");
        int opcao = int.Parse(Console.ReadLine());

        Jogador.JogadorFutebol jogador;

        switch (opcao)
        {
            case 1:
                jogador = new Jogador.JogadorDefesa();
                break;
            case 2:
                jogador = new Jogador.JogadorAtaque();
                break;
            case 3:
                jogador = new Jogador.JogadorMeioCampo();
                break;
            default:
                Console.WriteLine("Opção inválida. Informe um numero de 1 - 3");
                jogador = new Jogador.JogadorDefesa();
                break;
        }

        jogador.Nome = nome;
        jogador.DataNascimento = dataNascimento;
        jogador.Nacionalidade = nacionalidade;
        jogador.Altura = altura;
        jogador.Peso = peso;

        Console.WriteLine(@$"
         __________________________
        |                          |
        |  DADOS DO SEU JOGADOR:   |
        |__________________________|
        ");
        jogador.ImprimirDados();
        Console.WriteLine("Idade: " + jogador.CalcularIdade());
        Console.WriteLine("Tempo até se aposentar: " + jogador.TempoAteAposentar() + " anos");

        Console.ReadLine();
    }
}