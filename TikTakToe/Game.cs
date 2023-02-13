namespace TikTakToe;

public class Game
{
    public Board Board { get; set; }
    public void StartGame()
    {
        Board = new Board();
    }
}