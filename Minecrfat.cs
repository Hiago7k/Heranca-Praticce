namespace Heranca_Praticce;

internal class Minecrfat
{
   private List<string> ListaDeJogos = new();

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
