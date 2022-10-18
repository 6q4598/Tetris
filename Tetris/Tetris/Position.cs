namespace Tetris {

    public class Position {

        // Saves a row.
        public int Row {

            get;
            set;

        }

        // Saves a column.
        public int Column {

            get;
            set;

        }

        // Constructor.
        public Position (int row, int column) {

            Row = row;
            Column = column;

        }

    }

}
