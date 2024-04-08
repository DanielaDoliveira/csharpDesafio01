


using Desafio.Inputs.User.Interface;

namespace Desafio.Inputs.User;

public class InputUser : Input
{
    private string name;
    private string lastName;
    public InputUser(string _name = "", string _lastName = "")
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
        {

            throw new Exception("-----O USUARIO NAO DIGITOU O NOME-----");

        }
        else if (string.IsNullOrEmpty(lastName))
        {

            throw new Exception("-----O USUARIO NAO DIGITOU O SOBRENOME-----");
        }
        else
        {
            Console.WriteLine("Seu nome completo é " + name + " " + lastName);
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