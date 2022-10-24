using System;

namespace Tetris {

    public class GameGrid {

        /*
         * Create an array, which will be our board.
         * Te size of the array is 10x27.
         * If the row is full, delete it.
         * Then, we start at the bottom row and check if it's too.
         * Otherwise, look at the top row and delete it if it's full.
         * The loop is repeated until there are no more rows with pleaces.
         * Each time <<x>> row is deleted, the entire block above <<x>> lines below is moved and the clean variable will be incremented by <<x>>.
         * 
         * Variables:
         *  - r: number of row.
         *  - c: number of column.
         *  - cleared: contains the number of rows cleaned.
         */

        private readonly int[,] grid;

        // Initialice the rows.
        public int Rows {
            
            get;
        
        }

        // Initialize the columns.
        public int Columns {
            
            get;
        
        }

        // Create the array of cells.
        public int this[int r, int c] {

            get => grid[r, c];
            set => grid[r, c] = value;

        }

        // Initialize the array.
        public GameGrid (int rows, int columns) {

            Rows = rows;
            Columns = columns;
            grid = new int[Rows, Columns];

        }

        // Check if the cell is inside.
        public bool IsInside(int r, int c) {

            return r >= 0 && r < Rows && c >= 0 && c < Columns;

        }

        // Check if the cell is empty.
        public bool IsEmpty(int r, int c) {

            return IsInside(r, c) && grid[r, c] == 0;

        }

        // Check if the row is full.
        public bool IsRowFull (int r) {

            bool result = true;

            for (int col = 0; col < Columns; col++) {

                if (grid[r, col] == 0) {

                    result = false;

                }

            }

            return result;

        }

        // Check if the row is empty.
        public bool IsRowEmpty (int r) {

            for (int col = 0; col < Columns; col++) {

                if (grid[r, col] != 0) {

                    return false;

                }

            }

            return true;

        }

        // Clean a completed row.
        private void ClearRow (int r) {

            for (int col = 0; col < Columns; col++) {

                grid[r, col] = 0;

            }

        }

        // Move the top lines <<x>> position above.
        private void MoveRowDown (int r, int numRows) {

            for (int col = 0; col < Columns; col++) {

                grid[r + numRows, col] = grid[r, col];
                grid[r, col] = 0;

            }

        }

        // Clear <<x>> full rows.
        public int ClearFullRows() {

            int NumberLinesCleared = 0;

            // Tour all grid rows.
            for (int row = Rows - 1; row >= 0; row--) {

                // Verify if the actual row is cleared. Then, increments <<NumberLinesCleared>> and clear it.
                if (IsRowFull(row)) {

                    ClearRow(row);
                    NumberLinesCleared++;

                }

                // If <<NumberLinesCleared>> is > 0, moves the actual line <<x>> positions above.
                else if (NumberLinesCleared > 0){

                    MoveRowDown(row, NumberLinesCleared);

                }

                else {

                    ;

                }

            }

            return NumberLinesCleared;

        }

    }

}