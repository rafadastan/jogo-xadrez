
namespace chessboard
{
    class Piece
    {
        public Position position { get; set; }
        public Colors colors { get; protected set; }
        public int numberOfMoves { get; protected set; }
        public Chessboard chess { get; protected set; }

        public Piece(Colors colors, Chessboard chess)
        {
            this.position = null;
            this.colors = colors;
            this.chess = chess;
            this.numberOfMoves = 0;
        }
    }
}
