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

        public Piece piece(int row, int column)
        {
            return pieces[row, column];
        }
        public Piece piece(Position position)
        {
            return pieces[position.row, position.column];
        }

        public bool hasPiece(Position position)
        {
            PositionValid(position);
            return piece(position) != null;
        }

        public void putPieces(Piece p, Position pos)
        {
            if (hasPiece(pos))
            {
                throw new ChessboardException("There is already chess piece in this position!");
            }
            pieces[pos.row, pos.column] = p;
            p.position = pos;
        }

        public bool validPosition(Position position)
        {
            if (position.row < 0 || position.row>=rows || position.column<0 || position.column>=column)
            {
                return false;
            }
            return true;
        }

        public void PositionValid(Position position)
        {
            if (!validPosition(position))
            {
                throw new ChessboardException("Invalid Position!!");
            }
        }
    }
}
