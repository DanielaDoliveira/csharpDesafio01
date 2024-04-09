

namespace Desafio.Inputs.LicensePlate;

public class InputLicensePlate
{

    private string inputText;
    char threePos;
    private string message = "Bem vindo(a). Digite sua placa abaixo:\n";
    public void Execute()
    {
        Console.WriteLine(message);
        inputText = Console.ReadLine();
        ValidateLicensePlate(inputText);
    }
    public bool VerifySize(string _inputText)
    {

        //ex LUG4652
        bool verifyCharLimit = _inputText.Length == 7;

        if (!verifyCharLimit)
        {
            return false;
        }
        return true;

    }

    public bool VerifyFirstThreeLetters(string _inputText)
    {


        for (int i = 0; i < 3; i++)
        {
            threePos = _inputText[i];
            Console.WriteLine(threePos);
            if (!char.IsLetter(threePos))
                return false;
        }


        return true;


    }
    public bool VerifyLastFourNumbers(string _inputText)
    {
        for (int i = 3; i < 7; i++)
        {
            threePos = _inputText[i];
            Console.WriteLine(threePos);
            if (!char.IsNumber(threePos))
                return false;
        }
        return true;
    }

    public void ValidateLicensePlate(string _inputText)
    {
        VerifySize(_inputText);
        VerifyFirstThreeLetters(_inputText);
        VerifyLastFourNumbers(_inputText);

        if (!VerifySize(_inputText))
        {
            Console.WriteLine("Falsa ({0}). A quantidade de caracteres inseridos eh maior ou menor que o padrao permitido", false);
            Loading.LoadingFinishProgram();
        }
        else if (!VerifyFirstThreeLetters(_inputText))
        {
            Console.WriteLine("Falsa ({0}). O padrao das primeiras 3 letras esta incorreto", false);
            Loading.LoadingFinishProgram();
        }
        else if (!VerifyLastFourNumbers(_inputText))
        {
            Console.WriteLine("Falsa ({0}).O padrao dos ultimos 4 numeros esta incorreto", false);
            Loading.LoadingFinishProgram();
        }
        else
        {
            Console.WriteLine("Verdadeira ({0}). Sua placa foi verificada com sucesso", true);
            Loading.LoadingFinishProgram();
        }
    }
}
