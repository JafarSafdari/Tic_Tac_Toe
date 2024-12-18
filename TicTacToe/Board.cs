namespace TicTacToe
{
    public class Board
    {
        private const int Size = 3;
        private char[,] _cells;

        public Board()
        {
            _cells = new char[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    _cells[i, j] = ' ';
                }
            }
        }

        public char[,] GetCells()
        {
            return _cells;
        }

        public bool PlaceMarker(int x, int y, char marker)
        {
            if (_cells[x, y] != ' ')
                return false;

            _cells[x, y] = marker;
            return true;
        }
    }
}