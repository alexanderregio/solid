using System;
using System.Threading.Tasks;

namespace Principios.Solid.Dip
{
    /// <summary>
    /// Classe PessoasService implementa IPessoasService
    /// Os métodos implementados não dependem de uma implementação mas sim das abstrações da interface IDbRepository
    /// </summary>
    internal class PessoasService : IPessoasService
    {
        private readonly IDbRepository dbRepository;

        public PessoasService(IDbRepository dbRepository)
        {
            this.dbRepository = dbRepository;
        }

        public async Task<Pessoa> CadastrarPessoaAsync(Pessoa pessoa)
        {
            await dbRepository.CadastrarPessoaAsync(pessoa);
            return await dbRepository.ObterPessoaAsync(pessoa.Id);
        }

        public async Task<Pessoa> ObterPessoaAsync(Guid id)
        {
            return await dbRepository.ObterPessoaAsync(id);
        }
    }
}