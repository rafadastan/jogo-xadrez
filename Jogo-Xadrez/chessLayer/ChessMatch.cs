using chessboard;

namespace chessLayer
{
    class ChessMatch
    {
        public Chessboard chessboard { get; private set; }
        private int moveTurn;
        private Colors currentyPlay;

        public ChessMatch()
        {
            chessboard = new Chessboard(8, 8);
            moveTurn = 1;
            currentyPlay = Colors.Write;
            changePieces();
        }

        public void movePieces(Position origin, Position destination)
        {
            Piece p = chessboard.removePiece(origin);
            p.addNumberOfMoves();
            Piece capturedPiece = chessboard.removePiece(destination);
            chessboard.putPieces(p, destination);
        }

        private void changePieces()
        {
            chessboard.putPieces(new Tower(chessboard, Colors.Write), new PositionChessboard('c', 1).ToPosition());
            chessboard.putPieces(new Tower(chessboard, Colors.Write), new PositionChessboard('c', 2).ToPosition());
            chessboard.putPieces(new Tower(chessboard, Colors.Write), new PositionChessboard('d', 2).ToPosition());
            chessboard.putPieces(new Tower(chessboard, Colors.Write), new PositionChessboard('e', 2).ToPosition());
            chessboard.putPieces(new King(chessboard, Colors.Write), new PositionChessboard('d', 1).ToPosition());

        }
    }
}
