
using System.Globalization;
using Desafio;
using Desafio.Exceptions;

namespace InputName.Inputs.DateShow;

public class InputDateShow
{

    private DateTime input;
    private string formatDate;

    private string optionMenu;
    public void Execute()
    {
        input = DateTime.UtcNow.Date;



        Console.WriteLine("Escolha uma opcao: ");
        Console.WriteLine("\n 1 - Data no formato: dd/mm/aaaa  ");
        Console.WriteLine("\n 2 - Data no formato completo ");
        Console.WriteLine("\n 3 - Hora no formato hh:mm:ss e no formato de 24 horas ");
        Console.WriteLine("\n 4- Exibir apenas o dia e o mes ");
        optionMenu = Console.ReadLine();
        var opt = optionMenu.Replace(" ", "");
        OptionChooseDate(opt);

    }
    public void OnlyDateWithBar(DateTime _input)
    {
        formatDate = _input.ToString("dd/MM/yyyy", new CultureInfo("pt-BR"));


        Console.WriteLine(formatDate);
        Loading.LoadingFinishProgram();
    }
    public void DateInFull(DateTime _input)
    {
        formatDate = _input.ToLongDateString();
        var time = DateTime.UtcNow.ToString("HH:mm:ss");

        Console.WriteLine("São {0} e {1}", formatDate, time);
        Loading.LoadingFinishProgram();

    }
    public void GetHours(DateTime _input)
    {
        var time = DateTime.UtcNow.ToString("HH:mm:ss");
        Console.WriteLine(time);
        Loading.LoadingFinishProgram();
    }
    public void DateWithMonth(DateTime input)
    {
        var dateMonth = DateTime.UtcNow.ToString("m");
        Console.WriteLine(dateMonth);
        Loading.LoadingFinishProgram();
    }
    public void OptionChooseDate(string _opt)
    {

        ValidateOption(_opt);
        switch (_opt)
        {
            case "1":
                {
                    DateInFull(input);
                }
                break;
            case "2":
                {
                    OnlyDateWithBar(input);
                }
                break;
            case "3":
                {
                    GetHours(input);
                }
                break;
            case "4":
                {
                    DateWithMonth(input);
                }
                break;
            default:
                {
                    throw new OptionNotFoundedException("---OPCAO NAO ENCONTRADA");
                }
        }
    }
    void ValidateOption(string _opt)
    {
        if (string.IsNullOrEmpty(_opt))
        {
            throw new OptionNotFoundedException("---OPCAO NAO ENCONTRADA");
        }
    }

}