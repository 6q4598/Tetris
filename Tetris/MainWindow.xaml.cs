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

// DataBase access libraries.
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.ComponentModel.Design;
using System.Windows.Interop;

/***************************************
 * PROVA 1 VS GITHUB COMPTE PERSONAL   *
 ***************************************/

namespace Tetris {

    /*
     * <summary>
     * Interaction logic for MainWindow.xaml.
     * 
     * We have built this game using 2 technologies and a layered desing.
     * In the start, we hide the second layer (tetris game maked with XAML) and only shows
     * the loggin page. Then, when the user is logged or registered succesfully, we hide the first layer (loggin)
     * and shows the tetris game.
     * 
     * The first is built with "WindowsForms" and manages the login,
     * registration and scores of the players.
     * 
     * The second is the Tetris game and is made with XAMl.
     */

    public partial class MainWindow : Window {

        // Conexion BBDD string.
        static readonly string conexionString = "Server = 42-ARRUFI\\SQLEXPRESS; database = TetrisGame; integrated security = True";

        private readonly Image[,] imageControls;

        // Set the acceleration game.
        private readonly int maxDelay = 1000;
        private readonly int minDelay = 75;
        private readonly int delayDecrease = 25;

        // Private Class variables.
        private readonly string PlayingUser;
        private string ranking; 

        private GameState gameState = new GameState();

        // Default constructor: user is 'Default'.
        public MainWindow () {

            PlayingUser = "Default";
            ranking = getScoreRanking();
            this.Visibility = Visibility.Hidden;
            InitializeComponent();
            Hide();
            StartPage startPage = new StartPage();
            startPage.ShowDialog();
            Close();
            imageControls = SetupGameCanvas(gameState.GameGrid);

        }

        // Constructor two: user is logged.
        public MainWindow(bool playGame, string LoggedUser) {

            PlayingUser = LoggedUser;
            ranking = getScoreRanking();

            if (playGame == true) {
                
                InitializeComponent();

            }

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

        private static void ReturnTop5(IDataRecord dataRecord) {

            Console.WriteLine(String.Format("{0}, {1}", dataRecord[0], dataRecord[1]));

        }

        private string getScoreRanking() {

            string result = "";
            SqlConnection conexion = new SqlConnection(conexionString);
            conexion.Open();

            string getScoreRankingCommand = "SELECT TOP 5 userName, score FROM Score ORDER BY score DESC;"; 
            SqlCommand top5 = new SqlCommand(getScoreRankingCommand, conexion);

            try {

                SqlDataReader reader = top5.ExecuteReader();

                while (reader.Read()) {

                    result = result + (( string ) reader["userName"] + reader["score"]) + "\n";

                }

            }

            catch (Exception ex) {

                MessageBox.Show("Consult of the top 5 BEST PLAYERS IN THE WORLD failed: " + ex.Message + ".");

            }

            conexion.Close();
            return result;

        }

        private void Draw(GameState gameState) {

            DrawGrid(gameState.GameGrid);
            DrawGhostBlock(gameState.CurrentBlock);
            DrawBlock(gameState.CurrentBlock);
            DrawHoldBlock(gameState.HoldBlock);
            DrawNextBlock(gameState.BlockQueue);
            ScoreText.Text = $"Score: {gameState.Score}";
            UserBoard.Text = $"User: {PlayingUser}";
            ScoreRankingBoard.Text = $"{ranking}";

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

        // Write the user points in the BD.
        private async void GameCanvas_Loaded(object sender, RoutedEventArgs e) {

            await GameLoop();

        }

        private void ScorePoints(string points) {

            if (PlayingUser != "Default") {

                SqlConnection conexion = new SqlConnection(conexionString);
                conexion.Open();

                string insertScoreCommand = "INSERT INTO Score VALUES ('" + PlayingUser + "', " + points + ");";
                SqlCommand insertScore = new SqlCommand(insertScoreCommand, conexion);

                try {

                    SqlDataReader reader = insertScore.ExecuteReader();

                }

                catch (Exception ex) {

                    MessageBox.Show("Error putting the score in the BBDD: " + ex.Message);

                }

                conexion.Close();

            }

        }

        private async Task GameLoop () {

            Draw(gameState);

            while (!gameState.GameOver) {

                int delay = Math.Max(minDelay, maxDelay - ( gameState.Score * delayDecrease ));
                await Task.Delay(delay);
                gameState.MoveBlockDown();
                Draw(gameState);

            }

            // Score Points firts (only if points > 0).
            if (gameState.Score > 0) {

                ScorePoints($"{gameState.Score}");

            }

            // Draw Game Over.
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

                    gameState.HoldBlockFunction();
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

        private void Button_Click (object sender, RoutedEventArgs e) {

            Hide();
            StartPage startPage = new StartPage();
            startPage.ShowDialog();
            Close();

        }

    }

}