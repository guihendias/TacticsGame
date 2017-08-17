using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TacticsGame
{
    public class Board
    {

        public int RowNumber { get; private set; }
        public int ColumnNumber { get; private set; }

        private Cell[,] table = null;

        public Board(int rowNumber, int columnNumber)
        {
            RowNumber = rowNumber;
            ColumnNumber = columnNumber;
            table = new Cell[rowNumber, columnNumber];

            for (int i = 0; i < rowNumber; i++)
                for (int j = 0; j < columnNumber; j++)
                    table[i, j] = new Cell(new Vector2(i, j));
        }

        public override string ToString()
        {
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < RowNumber; i++)
                for (int j = 0; j < ColumnNumber; j++)
                {
                    if (table[i, j].IsOccupied)
                        sBuilder.Append(table[i, j].Occupant.Type.ToString()[0]);
                    else
                        sBuilder.Append(".");
                }
            return sBuilder.ToString();
        }

        public Cell this[int row, int column]
        {
            get { return table[row, column]; }
        }
    }
}
