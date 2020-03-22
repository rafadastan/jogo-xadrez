using Jogo_Xadrez.chessboard;
using System;

namespace Jogo_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Position position;

            position = new Position(3,4);

            Console.WriteLine("Position: " + position);
        }
    }
}
