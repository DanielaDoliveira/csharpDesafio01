

namespace Desafio;

public class Loading
{
    public static void LoadBetweenActivities()
    {
        Thread.Sleep(2000);
        Console.Clear();
    }
    public static void LoadingBetweenInstructions(int milisseconds = 1000)
    {
        Thread.Sleep(milisseconds);

    }
}