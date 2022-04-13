using System;

namespace Principios.Solid.Dip
{
    /// <summary>
    /// Classe de abstração de pessoa
    /// Contém apenas os atributos pertinentes à este domínio
    /// </summary>
    internal class Pessoa
    {
        /// <summary>
        /// Identificador da pessoa
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Cadastro de pessoa física da pessoa
        /// </summary>
        public long Cpf { get; set; }

        /// <summary>
        /// Primeiro nome da pessoa
        /// </summary>
        public string PrimeiroNome { get; set; }

        /// <summary>
        /// Sobrenome da pessoa
        /// </summary>
        public string SobreNome { get; set; }

        /// <summary>
        /// Data de nascimento da pessoa
        /// </summary>
        public DateTime DataNascimento { get; set; }
    }
}