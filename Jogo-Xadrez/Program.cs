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
                ChessMatch match = new ChessMatch();

                Screen.printChessBoard(match.chessboard);

                Console.WriteLine();
            }
            catch (ChessboardException e)
            {
                Console.WriteLine( e.Message);
            }
        }
    }
}
