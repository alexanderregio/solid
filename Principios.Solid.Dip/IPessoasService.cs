using System;
using System.Threading.Tasks;

namespace Principios.Solid.Dip
{
    /// <summary>
    /// Interface especializada para controle de pessoas
    /// </summary>
    internal interface IPessoasService
    {
        /// <summary>
        /// Cadastra uma nova pessoa
        /// </summary>
        /// <param name="pessoa">Dados da pessoa</param>
        /// <returns>Nova pessoa cadastrada</returns>
        public Task<Pessoa> CadastrarPessoaAsync(Pessoa pessoa);

        /// <summary>
        /// Obtém uma pessoa pelo identificador
        /// </summary>
        /// <param name="id">Identificador da pessoa</param>
        /// <returns>Dados da pessoa</returns>
        public Task<Pessoa> ObterPessoaAsync(Guid id);
    }
}