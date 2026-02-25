namespace Heranca_Praticce;

public   class Jogos
{
   public  List<string> ListaDeJogos = new();

    public virtual void Executar()
    {
        Console.WriteLine("Jogos na lista");
        foreach (var jogo in ListaDeJogos)
        {
            Console.WriteLine($"{jogo}");
        }
    }

    public virtual void World()
    {
        Console.WriteLine("Criando novo mundo!");
    }

    public virtual void AdicionarJogoNaLista(string lista)
    {
        ListaDeJogos.Add(lista);
    }

    //public virtual void MostrarJogosDaLista()
    //{
       
    //}
}
