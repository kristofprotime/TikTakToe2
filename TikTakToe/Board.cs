public class Board
{
    public List<Spot> Spots { get; set; }
    public bool IsEmpty()
    {
        return Spots.Select(s => s.Value == ' ').Count() == Spots.Count;
    }
}

public class Spot
{
    public char Value { get; set; }
}