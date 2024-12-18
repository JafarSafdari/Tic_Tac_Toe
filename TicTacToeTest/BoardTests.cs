using TicTacToe;

namespace TicTacToeTest;

public class BoardTests
{
    [Fact]
    public void Board_Should_Be_Initialized_With_Empty_Values()
    {
        var board = new Board();
        var cells = board.GetCells();

        var flatCells = cells.Cast<char>();

        Assert.All(flatCells, cell => Assert.Equal(' ', cell));
    }

    [Fact]
    public void PlaceMarker_Should_Update_Cell()
    {
        var board = new Board();
        var marker = 'X';

        // Försök att placera markören i den första cellen
        var result = board.PlaceMarker(0, 0, marker);

        // Testa att det lyckades och cellen nu har markerat värde
        Assert.True(result);
        Assert.Equal(marker, board.GetCells()[0, 0]);
    }
}