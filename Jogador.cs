namespace Heranca_Praticce;

internal class Jogador : Jogos
{
    public Jogador(string nomeDoJogador, int idadeDoJogador, DificuldadeDoJogo dificuldade)
    {
        NomeDoJogador = nomeDoJogador;
        IdadeDoJogador = idadeDoJogador;
        Dificuldade = dificuldade;
    }

    public string NomeDoJogador { get;  }
    public int IdadeDoJogador { get;  }
    public DificuldadeDoJogo Dificuldade { get; set; }


    public override void Executar()
    {
        base.World();
        Console.WriteLine("Seu mundo esta pronto");
    }

    public void ExibirDetalhesDoJogo()
    {
        Console.WriteLine($"{NomeDoJogador} {IdadeDoJogador} {Dificuldade.DificuldadeDoModo}");
    }

}
