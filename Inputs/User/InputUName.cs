

using System.ComponentModel.DataAnnotations;
using Desafio.Exceptions;
using Desafio.Interface;

namespace Desafio.Inputs.User
{

    public class InputUName : InputNames
    {
        private string name;
        public InputUName(string _name = "")
        {
            name = _name;

        }
        public void CallWelcomeMessage()
        {
            Validation();


        }
        public void Validation()
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ValidationErrorException("-----O USUARIO NAO DIGITOU O NOME-----");
            }

            else
            {
                Console.WriteLine("Olá, {0}! Seja muito bem vindo(a)!", name);
                Loading.LoadingFinishProgram();
            }
        }
        public void UserInputs()
        {
            Console.Clear();
            Console.WriteLine("Digite o seu nome abaixo: ");
            name = Console.ReadLine();

            CallWelcomeMessage();
        }
    }
}
