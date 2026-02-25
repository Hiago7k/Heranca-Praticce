using Heranca_Praticce;

Minecrfat jogo1 = new Minecrfat();
jogo1.AdicionarJogoNaLista("Minecraft");
jogo1.MostrarJogosDaLista();




DificuldadeDoJogo dificuldade = new DificuldadeDoJogo("Facil");
Jogador jogador1 = new Jogador("Steve", 23, dificuldade);
jogador1.ExibirDetalhesDoJogo();
jogador1.Executar(ListaDeJogos);

DificuldadeDoJogo dificuldade2 = new DificuldadeDoJogo("Dificil");
Jogador jogador2 = new Jogador("Alexa", 25, dificuldade2);
jogador2.ExibirDetalhesDoJogo();