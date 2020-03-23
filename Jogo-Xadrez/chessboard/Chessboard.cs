namespace chessboard
{
    class Chessboard
    {
        public int rows { get; set; }
        public int column { get; set; }
        private Piece [,] pieces { get; set; }

        public Chessboard(int rows, int column)
        {
            this.rows = rows;
            this.column = column;
            pieces = new Piece[rows, column];

        }
    }
}
