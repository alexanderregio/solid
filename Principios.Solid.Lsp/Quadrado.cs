using System;

namespace Principios.Solid.Lsp
{
    /// <summary>
    /// Classe Quadrado ao herdar de Paralelogramo obtém o comportamento de sua base
    /// Porém o cálculo da área não permite que as dimensões sejam de tamanho diferentes, porém, após validação do construtor a classe base oferece o cálculo
    /// </summary>
    internal class Quadrado : Paralelogramo
    {
        public Quadrado(int altura, int largura)
            : base(altura, largura)
        {
            if (largura != altura)
            {
                throw new ArgumentException("As dimensões do quadrado devem ser iguais");
            }
        }
    }
}