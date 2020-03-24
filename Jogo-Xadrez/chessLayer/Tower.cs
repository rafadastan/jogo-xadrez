using chessboard;

namespace chessLayer
{
    class Tower : Piece
    {
        public Tower(Chessboard chessboard, Colors colors) : base(colors, chessboard)
        {

        }

        public override string ToString()
        {
            return "T";
        }

    }
}
