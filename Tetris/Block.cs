using System.Collections.Generic;

namespace Tetris {

    /*
     * Define a abstract class for all blocks.
     * Define a subclass for each block.
     *  
     * For each block, we need:
     *  - Tiles: a bidimensional array position. That contains all the positions of the four rotations states.
     *  - StartOffset: an offset that decides the block position in the grid. 
     *  - Id: an integer to distinguish the type of block.
     *  
     * Variables:
     *  - rotationState (int).
     *  - offset (class Position).
     */

    public abstract class Block {

        private int rotationState;
        private Position offset;

        protected abstract Position[][] Tiles { get; }

        protected abstract Position StartOffset{ get; }

        public abstract int Id { get; }

        // Constructor.
        public Block () {

            offset = new Position(StartOffset.Row, StartOffset.Column);

        }

        // Tour the tetrominos positions in the actual state, and adds the row and column movements.
        public IEnumerable<Position> TilePositions() {

            foreach (Position p in Tiles[rotationState]) {

                yield return new Position(p.Row + offset.Row, p.Column + offset.Column);

            }

        }

        // Rotate clockwise 90º the tetromino (+1 the rotation state <<rotationState>> for each turn). 
        public void RotateCW() {

            rotationState = (rotationState + 1) % Tiles.Length;
        }

        // Rotate counterclockwise 90º the tetromino (-1 the rotation state <<rotationState>> for each turn). 
        public void RotateCCW() {

            if (rotationState == 0) {

                rotationState = Tiles.Length - 1;

            }

            else {

                rotationState--;

            }

        }

        // Moves the tetromino a given number of rows and columns.
        public void Move (int rows, int columns) {

            offset.Row += rows;
            offset.Column += columns;

        }

        // Reset the ratation and position of the tetromino.
        public void reset() {

            rotationState = 0;
            offset.Row = StartOffset.Row;
            offset.Column = StartOffset.Column;

        }

    }

}
