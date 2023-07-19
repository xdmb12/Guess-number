using Microsoft.Extensions.Configuration;
using GuessNumber.Resources;

namespace GuessNumber;

public class Logic
{
    public string GetResultOfUserInputWinOrLose(int userNumber, int myNumber)
    {
        try
        {
            if (userNumber == myNumber)
            {
                return GameResources.WinPhrase + "\n" + GameResources.ReadyOrNot;
            }

            return userNumber < myNumber ? GameResources.NumberBigger : GameResources.NumberSmaller;
        }
        catch (Exception)
        {
            throw new Exception("Problem with \"WinOrLose\" method");
        }
    }

    public int GetRandomGeneratedNumber()
    {
        var rd = new Random();
        try
        {
            IConfigurationBuilder _builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", false, true);
            var config = _builder.Build();

            var numStart = config.GetValue<int>("NumbersForRandomSettings:startNumber");
            var numEnd = config.GetValue<int>("NumbersForRandomSettings:untilNumber");

            var result = rd.Next(numStart, numEnd);
            return result;
        }
        catch (FileNotFoundException)
        {
            throw new FileNotFoundException("File with config not found");
        }
    }
}