namespace Cpsc370Final.Tests;

public class Game_Test
{
    [Fact]
    public void GetPlayTime_Default_Returns60Seconds()
    {
        // arrange
        var game = Game.GetInstance();
        
        // act
        var playTime = game.GetPlayTime();
        
        // assert
        Assert.Equal(TimeSpan.FromSeconds(60), playTime);
    }
}
