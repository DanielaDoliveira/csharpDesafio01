

namespace Desafio;

public class Loading
{
    public static void LoadBetweenActivities()
    {
        Thread.Sleep(2000);
        Console.Clear();
    }
    public static void LoadingBetweenInstructions(int _milisseconds = 1000)
    {
        Thread.Sleep(_milisseconds);

    }
    public static void LoadingFinishProgram()
    {
        Thread.Sleep(500);
        Console.WriteLine("Pressione ENTER para finalizar o programa ... \n");
        var inpuKey = Console.ReadKey();
        while (inpuKey.Key != ConsoleKey.Enter)
            inpuKey = Console.ReadKey();

        Thread.Sleep(1000);
        Console.WriteLine("Finalizando programa");
        Thread.Sleep(500);
        Console.WriteLine("... \n");
        Thread.Sleep(500);
        Console.Clear();


    }
}