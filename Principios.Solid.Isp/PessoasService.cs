using System;
using System.Threading.Tasks;

namespace Principios.Solid.Isp
{
    /// <summary>
    /// Classe responsável que implementa uma interface de serviço de pessoas
    /// Especializamos a interface pra atender somente a classes que irão implementar sobre este contexto e não será útil para outras classes
    /// </summary>
    internal class PessoasService : IPessoasService
    {
        public async Task<Pessoa> CadastrarPessoaAsync(Pessoa pessoa)
        {
            return await Task.Run(() => pessoa);
        }
        
        public async Task<Pessoa> ObterPessoaAsync(Guid id)
        {
            return await Task.Run(() => new Pessoa { Id = id });
        }
    }
}