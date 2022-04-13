namespace Principios.Solid.Lsp
{
    /// <summary>
    /// Classe Retangulo ao herdar de Paralelogramo obtém o comportamento de sua base
    /// Porém o cálculo da área permite que os atributos possuam dimensões diferentes
    /// </summary>
    internal class Retangulo : Paralelogramo
    {
        public Retangulo(int altura, int largura)
            : base(altura, largura) { }
    }
}