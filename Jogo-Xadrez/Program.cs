using chessboard;
using System;

namespace Jogo_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Chessboard chessboard = new Chessboard(8,8);

            Screen.printChessBoard(chessboard);

            Console.WriteLine();
        }
    }
}
