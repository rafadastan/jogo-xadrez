using chessboard;
using chessLayer;
using System;

namespace Jogo_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Chessboard chessboard = new Chessboard(8, 8);

                chessboard.putPieces(new Tower(chessboard, Colors.Black), new Position(0, 0));

                chessboard.putPieces(new Tower(chessboard, Colors.Black), new Position(1, 3));

                chessboard.putPieces(new King(chessboard, Colors.Black), new Position(2, 4));

                chessboard.putPieces(new Tower(chessboard, Colors.Write), new Position(3, 5));


                Screen.printChessBoard(chessboard);

                Console.WriteLine();
            }
            catch (ChessboardException e)
            {
                Console.WriteLine( e.Message);
            }
        }
    }
}
