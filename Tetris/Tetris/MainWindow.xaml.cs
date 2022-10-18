using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tetris {

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window {

        // Constructor.
        public MainWindow () {

            InitializeComponent();
            imageControls = SetupGameCanvas(gameState.GameGrid);

        }

        private readonly ImageSource[] tileImages = new ImageSource[] {

            new BitmapImage(new Uri("Assets/TileEmpty.png",  UriKind.Relative)),
            new BitmapImage(new Uri("Assets/TileCyan.png",   UriKind.Relative)),
            new BitmapImage(new Uri("Assets/TileBlue.png",   UriKind.Relative)),
            new BitmapImage(new Uri("Assets/TileOrange.png", UriKind.Relative)),

            new BitmapImage(new Uri("Assets/TileGreen.png",  UriKind.Relative)),
            new BitmapImage(new Uri("Assets/TilePurple.png", UriKind.Relative)),
            new BitmapImage(new Uri("Assets/TileRed.png",    UriKind.Relative)),
            new BitmapImage(new Uri("Assets/TileYellow.png", UriKind.Relative))

        };

        private readonly ImageSource[] blockImages = new ImageSource[] {

            new BitmapImage(new Uri("Assets/Block-Empty.png",  UriKind.Relative)),
            new BitmapImage(new Uri("Assets/Block-I.png",   UriKind.Relative)),
            new BitmapImage(new Uri("Assets/Block-J.png",   UriKind.Relative)),
            new BitmapImage(new Uri("Assets/Block-L.png", UriKind.Relative)),

            new BitmapImage(new Uri("Assets/Block-S.png",  UriKind.Relative)),
            new BitmapImage(new Uri("Assets/Block-T.png", UriKind.Relative)),
            new BitmapImage(new Uri("Assets/Block-Z.png",    UriKind.Relative)),
            new BitmapImage(new Uri("Assets/Block-O.png", UriKind.Relative))

        };

        private readonly Image[,] imageControls;

        // Set the acceleration game.
        private readonly int maxDelay = 1000;
        private readonly int minDelay = 75;
        private readonly int delayDecrease = 25;

        private GameState gameState = new GameState();

        private Image[,] SetupGameCanvas(GameGrid grid) {

            Image[,] imageControls = new Image[grid.Rows, grid.Columns];
            int cellSize = 25;

            for (int k = 0; k < grid.Rows; k++) {

                for (int l = 0; l < grid.Columns; l++) {

                    Image imageControl = new Image {

                        Width = cellSize,
                        Height = cellSize

                    };

                    // Push the top rows up so they aren't inside the canvas.
                    Canvas.SetTop(imageControl, ( k - 2 ) * cellSize + 10);

                    // The same for the columns.
                    Canvas.SetLeft(imageControl, l * cellSize);

                    GameCanvas.Children.Add(imageControl);
                    imageControls[k, l] = imageControl;

                }

            }

            return imageControls;

        }

        private void Draw(GameState gameState) {

            DrawGrid(gameState.GameGrid);
            DrawGhostBlock(gameState.CurrentBlock);
            DrawBlock(gameState.CurrentBlock);
            DrawHoldBlock(gameState.HoldBlock);
            DrawNextBlock(gameState.BlockQueue);
            ScoreText.Text = $"Score: {gameState.Score}";

        }

        private void DrawGrid(GameGrid grid) {

            for (int k = 0; k < grid.Rows; k++) {

                for (int l = 0; l < grid.Columns; l++) {

                    int id = grid[k, l];
                    imageControls[k, l].Opacity = 1;
                    imageControls[k, l].Source = tileImages[id];

                }

            }

        }

        private void DrawBlock(Block block) {

            foreach (Position p in block.TilePositions()) {

                imageControls[p.Row, p.Column].Opacity = 1;
                imageControls[p.Row, p.Column].Source = tileImages[block.Id];

            }

        }

        private void DrawHoldBlock(Block holdBlock) {

            if (holdBlock == null) {

                HoldImage.Source = blockImages[0];
                
            }

            else {

                HoldImage.Source = blockImages[holdBlock.Id];

            }

        }

        private void DrawNextBlock(BlockQueue blockQueue) {

            Block next = blockQueue.NextBlock;
            NextImage.Source = blockImages[next.Id];

        }

        // Spawns a ghost tetromino copy of the current one below the board.
        private void DrawGhostBlock(Block block) {

            int dropDistance = gameState.BlockDropDistance();

            foreach (Position p in block.TilePositions()) {

                imageControls[p.Row + dropDistance, p.Column].Opacity = 0.25;
                imageControls[p.Row + dropDistance, p.Column].Source = tileImages[block.Id];

            }

        }

        private async void GameCanvas_Loaded(object sender, RoutedEventArgs e) {

            await GameLoop();

        }

        private async Task GameLoop() {

            Draw(gameState);

            while (!gameState.GameOver) {

                int delay = Math.Max(minDelay, maxDelay - ( gameState.Score * delayDecrease ));
                await Task.Delay(500);
                gameState.MoveBlockDown();
                Draw(gameState);

            }

            GameOverMenu.Visibility = Visibility.Visible;
            FinalScoreText.Text = $"Final score: {gameState.Score}";

        }

        private void Window_KeyDown(object sender, KeyEventArgs e) {

            if (gameState.GameOver) {

                return;

            }

            switch (e.Key) {

                case Key.Left:

                    gameState.MoveBlockLeft();
                    break;

                case Key.Right:

                    gameState.MoveBlockRight();
                    break;

                case Key.Down:

                    gameState.MoveBlockDown();
                    break;

                case Key.Up:

                    gameState.RotateBlockCW();
                    break;
                
                case Key.Z:

                    gameState.RotateBlockCCW();
                    break;

                case Key.S:

                    gameState.HoldBlock_01();
                    break;

                case Key.Space:

                    gameState.DropBlock();
                    break;

                default:

                    return;

            }

            Draw(gameState);

        }

        private async void PlayAgain_Click (object sender, RoutedEventArgs e) {

            gameState = new GameState();
            GameOverMenu.Visibility = Visibility.Hidden;
            await GameLoop();

        }


    }

}
