
using Desafio.Exceptions;
using Desafio.Inputs.CharCount;
using Desafio.Inputs.Math;
using Desafio.Inputs.User;


namespace Desafio;

public class OptionsMenu
{

    string message = "Selecione uma opção: \n 1-Exercício 1\n 2-Exercício 2  \n 3-Exercício 3 \n 4- Exercício 4 \n 5-Exercício 5\n";
    string input;

    public void Execute()
    {
        Console.WriteLine(message);
        input = Console.ReadLine();
        Options(input);

    }
    public void Options(string _input)
    {
        switch (_input)
        {

            case "1":
                {
                    Loading.LoadBetweenActivities();
                    Console.WriteLine("\n ... Exercício 1 ... \n");
                    InputName inputName = new InputName();
                    inputName.UserInputs();
                }
                break;
            case "2":
                {
                    Loading.LoadBetweenActivities();
                    Console.WriteLine("\n ... Exercício 2 ... \n");
                    Loading.LoadBetweenActivities();
                    InputUserNameLastName inputUserNameLastName = new InputUserNameLastName();
                    inputUserNameLastName.UserInputs();
                }
                break;
            case "3":
                {
                    Loading.LoadBetweenActivities();
                    Console.WriteLine("\n ... Exercício 3 ... \n");
                    InputCalculator inputCalculator = new InputCalculator();
                    inputCalculator.Execute();
                }
                break;
            case "4":
                {
                    Loading.LoadBetweenActivities();
                    Console.WriteLine("\n ... Exercício 4 ... \n");
                    InputCountChar inputCountChar = new InputCountChar();
                    inputCountChar.Execute();

                }
                break;
            default:
                {

                    throw new OptionNotFoundedException("-----OPCAO NAO ENCONTRADA!-----");

                }
                break;
        }
    }



}