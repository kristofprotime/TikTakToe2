using TikTakToe;

namespace TikTakToeTests;

public class GameTest
{
    [Fact]
    public void StartGame_MakesEmptyBoard()
    {
        Game game = new Game();

        game.StartGame();
        
        Assert.False(game.Board.IsEmpty());
    }
}