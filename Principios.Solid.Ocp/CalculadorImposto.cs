namespace Principios.Solid.Ocp
{
    /// <summary>
    /// Classe responsável em realizar o cálculo do imposto independente do seu tipo
    /// Qualquer novo imposto implementado não será necessário alterar esta classe
    /// </summary>
    internal static class CalculadorImposto
    {
        public static decimal Calcular(decimal valor, Imposto imposto)
        {
            return imposto.Calcular(valor);
        }
    }
}