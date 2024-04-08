

using Desafio.Inputs.User.Interface;

namespace Desafio.Inputs.User;

public class InputName : Input
{
    private string name;
    public InputName(string _name = "")
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


            throw new Exception("-----O USUARIO NAO DIGITOU O NOME-----");

        }

        else
        {
            Console.WriteLine("Olá, {0}! Seja muito bem vindo(a)!", name);
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