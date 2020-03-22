﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Jogo_Xadrez.chessboard
{
    class Position
    {
        public int row { get; set; }
        public int column { get; set; }

        public Position(int row, int column)
        {
            this.row = row;
            this.column = column;
        }

        public override string ToString()
        {
            return row
                +", "
                + column;
        }
    }
}