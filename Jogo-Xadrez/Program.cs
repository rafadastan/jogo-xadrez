using chessboard;
using chessLayer;
using System;

namespace Jogo_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            PositionChessboard position = new PositionChessboard('a', 1);

            Console.WriteLine(position);

            Console.ReadLine();
        }
    }
}
