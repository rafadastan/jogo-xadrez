using chessboard;

namespace Jogo_Xadrez
{
    class Screen
    {
        public static void printChessBoard(Chessboard chessboard)
        {
            for (int i = 0; i < chessboard.rows; i++)
            {
                for (int j = 0; j < chessboard.column; j++)
                {
                    if (chessboard.piece(i,j) == null)
                    {
                        System.Console.Write("- ");
                    }
                    else
                    {
                        System.Console.Write(chessboard.piece(i, j) + " ");
                    }
                }
                System.Console.WriteLine();
            }
        } 
    }
}
