


using Desafio.Exceptions;
using Desafio.Inputs.User;

namespace Desafio.Inputs.User;

public class InputUserNameLastName
{
    private string name;
    private string lastName;
    public InputUserNameLastName(string _name = "", string _lastName = "")
    {
        name = _name;

        lastName = _lastName;
    }
    public void CallWelcomeMessage()
    {
        Validation();


    }
    public void Validation()
    {
        if (string.IsNullOrEmpty(name))
            throw new ValidationErrorException("-----O USUARIO NAO DIGITOU O NOME-----");

        else if (string.IsNullOrEmpty(lastName))
            throw new ValidationErrorException("-----O USUARIO NAO DIGITOU O SOBRENOME-----");

        else
        {
            Console.WriteLine("Seu nome completo é " + name + " " + lastName);
            Loading.LoadingFinishProgram();
        }
    }
    public void UserInputs()
    {
        Console.Clear();
        Console.WriteLine("Digite o seu nome abaixo: ");
        name = Console.ReadLine();
        Console.WriteLine("Agora digite o seu sobrenome abaixo: ");
        lastName = Console.ReadLine();
        CallWelcomeMessage();
    }
}