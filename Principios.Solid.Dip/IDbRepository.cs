using System;
using System.Threading.Tasks;

namespace Principios.Solid.Dip
{
    /// <summary>
    /// Interface contendo contrato para controle de acesso ao banco de dados
    /// </summary>
    internal interface IDbRepository
    {
        /// <summary>
        /// Cadastra uma nova pessoa
        /// </summary>
        /// <param name="pessoa">Dados da pessoa</param>
        public Task CadastrarPessoaAsync(Pessoa pessoa);

        /// <summary>
        /// Obtém uma pessoa pelo identificador
        /// </summary>
        /// <param name="id">Identificador da pessoa</param>
        /// <returns>Dados da pessoa</returns>
        public Task<Pessoa> ObterPessoaAsync(Guid id);
    }
}
