namespace Heranca_Praticce;

internal class DificuldadeDoJogo : Jogos

{
    public DificuldadeDoJogo(string dificuldadeDoModol)
    {
        DificuldadeDoModo = dificuldadeDoModol;
    }
    public string DificuldadeDoModo { get; set; }
}
