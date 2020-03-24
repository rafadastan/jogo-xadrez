﻿namespace chessboard
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

        public void putPieces(Piece p, Position pos)
        {
            pieces[pos.row, pos.column] = p;
            p.position = pos;
        }
    }
}
