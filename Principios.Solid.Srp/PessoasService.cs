using System;
using System.Threading.Tasks;

namespace Principios.Solid.Srp
{
    /// <summary>
    /// Classe responsável pelos serviços oferecidos para o domínio de uma pessoa
    /// Aqui serão aplicadas as regras de negócio sobre uma pessoa, sendo assim, esta classe não deve tratar outros domínios, por exemplo: Cadastrar um objeto da classe Carro
    /// Ou seja, a classe possui a responsabilidade de manter uma pessoa
    /// </summary>
    internal class PessoasService
    {
        private readonly DatabaseRepository databaseRepository;
        private readonly EmailsService emailsService;

        public PessoasService()
        {
            databaseRepository = new DatabaseRepository();
            emailsService = new EmailsService();
        }

        /// <summary>
        /// Cadastra uma nova pessoa
        /// </summary>
        /// <param name="pessoa">Dados da pessoa</param>
        /// <returns>Nova pessoa cadastrada</returns>
        public async Task<Pessoa> CadastrarPessoaAsync(Pessoa pessoa)
        {
            await databaseRepository.CadastrarPessoaAsync(pessoa);
            await emailsService.EnviarEmailAsync("email@mail.com", "Cadastro no sistema", "Cadastro realizado com sucesso");

            return await databaseRepository.ObterPessoaAsync(pessoa.Id);
        }

        /// <summary>
        /// Obtém uma pessoa pelo identificador
        /// </summary>
        /// <param name="id">Identificador da pessoa</param>
        /// <returns>Dados da pessoa</returns>
        public async Task<Pessoa> ObterPessoaAsync(Guid id)
        {
            return await databaseRepository.ObterPessoaAsync(id);
        }
    }
}