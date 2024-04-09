
using Desafio.Exceptions;
using Desafio.Inputs.User;
using Desafio.Inputs.CharCount;
using Desafio.Inputs.Math;
using Desafio.Inputs.LicensePlate;
using InputName.Inputs.DateShow;


namespace Desafio;

public class OptionsMenu
{

    string message = "Selecione uma opção: \n 1-Exercício 1\n 2-Exercício 2  \n 3-Exercício 3 \n 4- Exercício 4 \n 5-Exercício 5\n";
    string input;

    public void Execute()
    {
        Console.WriteLine(message);
        input = Console.ReadLine();
        var input_result = input.Replace(" ", "");
        Options(input_result);

    }
    public void Options(string _input)
    {
        switch (_input)
        {

            case "1":
                {
                    Loading.LoadBetweenActivities();
                    Console.WriteLine("\n ... Exercício 1 ... \n");
                    InputUName inputUName = new InputUName();
                    inputUName.Execute();
                }
                break;
            case "2":
                {
                    Loading.LoadBetweenActivities();
                    Console.WriteLine("\n ... Exercício 2 ... \n");
                    Loading.LoadBetweenActivities();
                    InputUserNameLastName inputUserNameLastName = new InputUserNameLastName();
                    inputUserNameLastName.Execute();
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
            case "5":
                {
                    Loading.LoadBetweenActivities();
                    Console.WriteLine("\n ... Exercicio 5 ... \n");
                    InputLicensePlate inputLicensePlate = new InputLicensePlate();
                    inputLicensePlate.Execute();

                }
                break;
            case "6":
                {
                    Loading.LoadBetweenActivities();
                    Console.WriteLine("\n ... Exercicio 6 ... \n");
                    InputDateShow inputDateShow = new InputDateShow();
                    inputDateShow.Execute();

                }
                break;
            default:
                {

                    throw new OptionNotFoundedException("-----OPCAO NAO ENCONTRADA!-----");

                }

        }
    }



}