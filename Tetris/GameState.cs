using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace Tetris {

    /*
     * Manages the interactions between the board and the tetrominoes,
     * as well as between the tetrominos themselves.
     * 
     * When a new tetromino appears, a reset must be done so that it
     * appears in the initial positions.
     */

    internal class GameState {

        // Current block backup field.
        private Block currentBlock;

        public GameGrid GameGrid { get; }

        public BlockQueue BlockQueue { get; }

        public bool GameOver { get; private set; }

        public Block HoldBlock { get; private set; }

        public bool CanHold { get; private set; }

        public int Score { get; private set; }

        // Constructor: set the board as 22x10; get a new random tetromino.
        public GameState() {

            GameGrid = new GameGrid(22, 10);
            BlockQueue = new BlockQueue();
            CurrentBlock = BlockQueue.GetAndUpdate();
            CanHold = true;

        }         

        // New tetromino.
        public Block CurrentBlock {

            get => currentBlock;
            private set {

                currentBlock = value;
                currentBlock.reset();

                for (int k = 0; k < 2; k++) {

                    currentBlock.Move(1, 0);

                    if (!BlockFits()) {

                        currentBlock.Move(-1, 0);

                    }
                }

            }

        }

        // IMPORTANT: Check if the current block is in <<legal>> position.
        private bool BlockFits() {

            bool result = true;

            // Check if any tetromino's piece is off the board.
            foreach (Position p in currentBlock.TilePositions()) {

                if (!GameGrid.IsEmpty(p.Row, p.Column)) {

                    result = false;

                }

            }

            return result;

        }

        // Clockwise rotation.
        public void RotateBlockCW() {

            CurrentBlock.RotateCW();

            // If the rotated tetromino is off the board, we rotate it again.
            if (!BlockFits()) {

                CurrentBlock.RotateCCW();

            }

        }

        // CounterClockwise rotation.
        public void RotateBlockCCW() {

            CurrentBlock.RotateCCW();

            if (!BlockFits()) {

                CurrentBlock.RotateCCW();

            }

        }

        // Move tetromino left.
        public void MoveBlockLeft() {

            CurrentBlock.Move(0, -1);

            if (!BlockFits()) {

                CurrentBlock.Move(0, 1);

            }

        }

        // Move tetromino right.
        public void MoveBlockRight() {

            CurrentBlock.Move(0, 1);

            if (!BlockFits()) {

                CurrentBlock.Move(0, -1);

            }

        }

        // Move tetromino bottom.
        public void MoveBlockDown() {

            CurrentBlock.Move(1, 0);

            if (!BlockFits()) {

                CurrentBlock.Move(-1, 0);

                // Checks if the tetromino can moves bottom.
                PlaceBlock();

            }

        }

        // Checks if the game is over.
        private bool IsGameOver() {

            return !( GameGrid.IsRowEmpty(0) && GameGrid.IsRowEmpty(1) );

        }

        // When the block can move bottom.
        private void PlaceBlock() {

            // Set actual positions of current tetromino.
            foreach (Position p in CurrentBlock.TilePositions()) {

                GameGrid[p.Row, p.Column] = CurrentBlock.Id;

            }

            // Clear complete lines.
            Score += GameGrid.ClearFullRows();

            // Checks if the game is over.
            if (IsGameOver()) {

                GameOver = true;

            }

            else {

                CurrentBlock = BlockQueue.GetAndUpdate();
                CanHold = false;

            }

        }

        public void HoldBlockFunction() {

            if (!CanHold) {

                return;

            }

            if (HoldBlock == null) {

                HoldBlock = CurrentBlock;
                CurrentBlock = BlockQueue.GetAndUpdate();

            }

            else {

                Block tmp = CurrentBlock;
                CurrentBlock = HoldBlock;
                HoldBlock = tmp;

            }

            CanHold = false;

        }

        // Return the number of empty rows below the current tetromino.
        private int TileDropDistance(Position p) {

            int numberRows = 0;

            while (GameGrid.IsEmpty(p.Row + numberRows + 1, p.Column)) {

                numberRows++;

            }

            return numberRows;

        }

        public int BlockDropDistance () {

            int numberRows = GameGrid.Rows;

            foreach (Position p in CurrentBlock.TilePositions()) {

                numberRows = System.Math.Min(numberRows, TileDropDistance(p));

            }

            return numberRows;

        }

        // Move a tetromino under.
        public void DropBlock() {

            CurrentBlock.Move(BlockDropDistance(), 0);
            PlaceBlock();

        }

    }

}
