using System;

namespace Tetris {

    /*
     * This class is responsible for choosing the next tetromino in the game.
     * This class contains an instance with the 7 different types of tetromino.
     * The tetrominos are choosed randomly.
     * 
     * When we are playing, the following figure will be displayed so that the player can know
     * what is coming.
     * We don't want to have the same tetromino twice in a row.
     */

    public class BlockQueue {

        // Constructor: initialize the following tetromino randomly with <<RandomBlock>>.
        public BlockQueue () {

            NextBlock = RandomBlock();
        }

        // Initialize all tetrominos.
        private readonly Block[] blocks = new Block[] {

            new IBlock(),
            new JBlock(),
            new LBlock(),
            new OBlock(),
            new SBlock(),
            new TBlock(),
            new ZBlock()

        };

        // Random value.
        private readonly Random random = new Random();

        // Next tetromino's property.
        public Block NextBlock {

            get;
            private set;

        }

        // Return a random tetromino.
        private Block RandomBlock() {

            return blocks[random.Next(blocks.Length)];

        }

        // Return next tetromino and sets his properties.
        public Block GetAndUpdate() {

            Block block = NextBlock;

            do {

                NextBlock = RandomBlock();

            } while (block.Id == NextBlock.Id);

            return block;

        }

    }

}
