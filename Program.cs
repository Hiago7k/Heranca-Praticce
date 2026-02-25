using Heranca_Praticce;


DificuldadeDoJogo dificuldade = new DificuldadeDoJogo("Facil");

Jogador jogador1 = new Jogador("Steve", 23, dificuldade);
Console.WriteLine($"{jogador1.NomeDoJogador} {jogador1.IdadeDoJogador} {jogador1.Dificuldade.DificuldadeDoModo}");

DificuldadeDoJogo dificuldade2 = new DificuldadeDoJogo("Dificil");

Jogador jogador2 = new Jogador("Alexa", 25, dificuldade2);
Console.WriteLine($"{jogador2.NomeDoJogador} {jogador2.IdadeDoJogador} {jogador2.Dificuldade.DificuldadeDoModo}");