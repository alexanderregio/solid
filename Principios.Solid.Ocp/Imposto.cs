namespace Principios.Solid.Ocp
{
    /// <summary>
    /// Classe abstrata para abstração de um tipo de imposto
    /// Todo novo imposto deve herdar desta classe
    /// </summary>
    internal abstract class Imposto
    {
        /// <summary>
        /// Método abstrato que deve realizar o cálculo do imposto sobre o valor
        /// </summary>
        /// <param name="valor">Valor que será aplicado o imposto</param>
        /// <returns>Valor calculado do imposto</returns>
        public abstract decimal Calcular(decimal valor);
    }
}
