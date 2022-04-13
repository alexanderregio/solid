using System;
using System.Threading.Tasks;

namespace Principios.Solid.Srp
{
    /// <summary>
    /// Classe responsável por realizar a comunicação com o banco de dados
    /// </summary>
    internal class DatabaseRepository
    {
        /// <summary>
        /// Cadastra uma nova pessoa
        /// </summary>
        /// <param name="pessoa">Dados da pessoa</param>
        public async Task CadastrarPessoaAsync(Pessoa pessoa)
        {
            await Task.CompletedTask;
        }

        /// <summary>
        /// Obtém uma pessoa pelo identificador
        /// </summary>
        /// <param name="id">Identificador da pessoa</param>
        /// <returns>Dados da pessoa</returns>
        public async Task<Pessoa> ObterPessoaAsync(Guid id)
        {
            return await Task.Run(() => new Pessoa { Id = id });
        }
    }
}
