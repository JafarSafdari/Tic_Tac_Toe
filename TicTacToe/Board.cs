namespace TicTacToe;

public class Board
{
    private char[,] cells = new char[3, 3];

    public bool IsEmpty()
    {
        foreach (var cell in cells)
        {
            if (cell != ' ') return false; // Cell should be empty (' ')
        }

        return true;
    }
}