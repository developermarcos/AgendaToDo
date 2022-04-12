using System;
namespace AgendaToDo.ConsoleApp.Compartilhado
{
    public enum TipoMensagem
    {
        Sucesso, Atencao, Erro
    }
    public class Notificador
    {
        public void ApresentarMensagem(string mensagem, TipoMensagem status)
        {
            switch (status)
            {
                case TipoMensagem.Sucesso:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                case TipoMensagem.Atencao:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;

                case TipoMensagem.Erro:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                default:
                    break;
            }

            Console.WriteLine();
            Console.WriteLine(mensagem);
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
