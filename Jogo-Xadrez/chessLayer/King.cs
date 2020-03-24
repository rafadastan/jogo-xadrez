using chessboard;

namespace chessLayer
{
    class King : Piece
    {
        public King(Chessboard chessboard, Colors colors) : base(colors, chessboard)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
