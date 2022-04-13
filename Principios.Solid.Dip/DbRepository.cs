using System;
using System.Threading.Tasks;

namespace Principios.Solid.Dip
{
    /// <summary>
    /// Classe DbRespository implementa IDbRepository
    /// </summary>
    internal class DbRepository : IDbRepository
    {
        public async Task CadastrarPessoaAsync(Pessoa pessoa)
        {
            await Task.CompletedTask;
        }

        public async Task<Pessoa> ObterPessoaAsync(Guid id)
        {
            return await Task.Run(() => new Pessoa { Id = id });
        }
    }
}