namespace Heranca_Praticce;

internal class Jogador : Minecrfat
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


    //public override void ExibirDetalhesDoJogo()
    //{
    //    base.World;
    //    Console.WriteLine($"{NomeDoJogador} {IdadeDoJogador} {Dificuldade.DificuldadeDoModo}");
    //}

}
