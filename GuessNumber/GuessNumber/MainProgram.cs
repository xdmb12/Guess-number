namespace GuessNumber;

public class MainProgram
{
    public static void Main(string[] args)
    {
        var game = new UserInteraction();

        try
        {
            game.GameProcess();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}