namespace Principios.Solid.Lsp
{
    /// <summary>
    /// Classe abstrata para representação de um figura geométrica
    /// </summary>
    public abstract class Paralelogramo
    {
        protected Paralelogramo(int altura, int largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public double Altura { get; private set; }

        public double Largura { get; private set; }

        public double Area
            => Altura * Largura;
    }
}