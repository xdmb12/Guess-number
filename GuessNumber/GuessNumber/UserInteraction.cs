using GuessNumber.Resources;

namespace GuessNumber;

public class UserInteraction
{
    public void GameProcess()
    {
        var lg = new Logic();
        int myNumber = lg.GetRandomGeneratedNumber();

        while (true)
        {
            Console.WriteLine(GameResources.EnterPhrase);
            var userInput = Console.ReadLine();

            if (int.TryParse(userInput, out var userNumber))
            {
                var result = lg.GetResultOfUserInputWinOrLose(userNumber, myNumber);

                Console.WriteLine(result);

                if (result.Contains(GameResources.WinPhrase))
                {
                    myNumber = lg.GetRandomGeneratedNumber();

                    if (userInput.ToUpper() != "Y")
                    {
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine(GameResources.ErrorPhrase);
            }
        }
    }
}