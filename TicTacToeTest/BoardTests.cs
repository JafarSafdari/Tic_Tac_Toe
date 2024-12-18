using TicTacToe;

namespace TicTacToeTest;

public class BoardTests
{
    [Fact]
    public void Should_InitializeBoard_Empty()
    {
        var board = new Board();
        var isEmpty = board.IsEmpty();  // Assume we have a method to check if the board is empty.
    
        Assert.True(isEmpty);
    }
    
}