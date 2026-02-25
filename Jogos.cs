namespace Heranca_Praticce;

public  class Minecrfat
{
   public List<string> ListaDeJogos = new();

    public virtual void Executar(List<string> ListaDeJogos)
    {
    }


    public void World()
    {
        Console.WriteLine("Criando novo mundo!");
    }

    public void AdicionarJogoNaLista(string lista)
    {
        ListaDeJogos.Add(lista);
    }

    public void MostrarJogosDaLista()
    {
        foreach (var jogo in ListaDeJogos)
        {
            Console.WriteLine($"{jogo}");
        }
    }
}
