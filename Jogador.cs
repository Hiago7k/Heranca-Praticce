namespace Heranca_Praticce;

internal class Jogador
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

}
