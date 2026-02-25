using Heranca_Praticce;



Jogos jogo1 = new Jogos();
jogo1.AdicionarJogoNaLista("Minecraft");
//jogo1.MostrarJogosDaLista();
jogo1.Executar();


//Dictionary<string, Jogos> jogosRegistrados = new();
//jogosRegistrados.Add("Minecraft", jogo1);

DificuldadeDoJogo dificuldade = new DificuldadeDoJogo("Facil");
Jogador jogador1 = new Jogador("Steve", 23, dificuldade);
jogador1.ExibirDetalhesDoJogo();


DificuldadeDoJogo dificuldade2 = new DificuldadeDoJogo("Dificil");
Jogador jogador2 = new Jogador("Alexa", 25, dificuldade2);
jogador2.ExibirDetalhesDoJogo();

