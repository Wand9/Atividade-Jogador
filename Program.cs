// 1.Crie uma classe abstrata para representar um jogador de futebol, com os atributos nome, data de nascimento, nacionalidade, altura e peso.

// Crie um método para imprimir todos os dados do jogador.

//Crie um método para calcular a idade do jogador e outro método para mostrar quanto tempo falta para o jogador se aposentar. 

//Para isso, crie outras 3 subclasses, JOGADORDEFESA, JOGADORATAQUE e JOGADORMEIO-CAMPO considere que os jogadores da posição de defesa se aposentam em média aos 40 anos, os jogadores de meio-campo aos 38 e os atacantes aos 35.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite os dados do jogador:");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Data de Nascimento: ");
        DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
        Console.Write("Nacionalidade: ");
        string nacionalidade = Console.ReadLine();
        Console.Write("Altura: ");
        float altura = float.Parse(Console.ReadLine());
        Console.Write("Peso: ");
        float peso = float.Parse(Console.ReadLine());

        Jogador.JogadorDefesa jogadorDefesa = new Jogador.JogadorDefesa
        {
            Nome = nome,
            DataNascimento = dataNascimento,
            Nacionalidade = nacionalidade,
            Altura = altura,
            Peso = peso,

        };

    Console.WriteLine("Dados do jogador:");
    jogadorDefesa.ImprimirDados();
    Console.WriteLine("Idade: " + jogadorDefesa.CalcularIdade());
    Console.WriteLine("Tempo até se aposentar: " + jogadorDefesa.TempoAteAposentar() + "anos");

    Console.ReadLine();
    }
}