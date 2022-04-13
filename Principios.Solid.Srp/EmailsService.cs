using System.Threading.Tasks;

namespace Principios.Solid.Srp
{
    internal class EmailsService
    {
        public async Task EnviarEmailAsync(string emailDestinatario, string titulo, string mensagem)
        {
            // ... código para envio do e-mail
            await Task.CompletedTask;
        }
    }
}