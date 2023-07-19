using GuessNumber;

namespace GuessNumberTest;

public class GuessNumberTest
{
    private readonly Logic lg = new Logic();

    [Theory]
    [InlineData(20, 30, "My number is bigger!")]
    [InlineData(30, 20, "My number is smaller!")]
    [InlineData(30, 30, "You won this game!!!\nDo you wanna play more(Y/N)?")]
    [InlineData(-20, 30, "My number is bigger!")]
    [InlineData(30, -20, "My number is smaller!")]
    [InlineData(null, null, "You won this game!!!\nDo you wanna play more(Y/N)?")]
    public void GetResultOfGame(int userNumber, int myNumber, string expectedResult)
    {
        var result = lg.GetResultOfUserInputWinOrLose(userNumber, myNumber);
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void TestMethodReturnsNumber()
    {
        var result = lg.GetRandomGeneratedNumber();

        Assert.True(result >= 0 && result < 101);
    }
}