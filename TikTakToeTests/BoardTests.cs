namespace TikTakToeTests;

public class BoardTests
{
    [Fact]
    public void IsEmpty_ReturnsTrueWhenSpotsAreEmpty()
    {
        var board = new Board();
        board.Spots = new List<Spot>
        {
            new Spot() { Value = ' ' },
            new Spot() { Value = ' ' },
            new Spot() { Value = ' ' }
        };

        var isEmpty = board.IsEmpty();
        
        Assert.True(isEmpty);
        
    }
}