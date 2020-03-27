using chessboard;
using System;

namespace Jogo_Xadrez
{
    class Screen
    {
        public static void printChessBoard(Chessboard chessboard)
        {
            for (int i = 0; i < chessboard.rows; i++)
            {
                System.Console.Write(8 - i + " ");
                for (int j = 0; j < chessboard.column; j++)
                {
                    if (chessboard.piece(i,j) == null)
                    {
                        System.Console.Write("- ");
                    }
                    else
                    {
                        printPiece(chessboard.piece(i, j));
                        Console.Write(" ");
                    }
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine(" A B C D E F G H ");
        } 

        public static void printPiece(Piece piece)
        {
            if (piece.colors == Colors.Write)
            {
                System.Console.WriteLine(piece);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece);
                Console.ForegroundColor = aux;
            }
        }
    }
}
