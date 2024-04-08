


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

            Console.WriteLine("Você precisa digitar um nome!");

        }
        else if (string.IsNullOrEmpty(lastName))
        {

            Console.WriteLine("Você precisa digitar seu sobrenome!");
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