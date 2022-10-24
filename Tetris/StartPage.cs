using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using pswHash;

namespace Tetris {


    public partial class StartPage : Form {
        
        static readonly string conexionString = "Server = 42-ARRUFI\\SQLEXPRESS; database = TetrisGame; integrated security = True";

        // Call private class Encrypt.
        EncryptClass encryptClass = new EncryptClass();

        public StartPage () {

            InitializeComponent();

        }

        private void startTetris(string user) {

            Hide();
            MainWindow main = new MainWindow(true, user);
            main.ShowDialog();
            Close();

        }

        private void buttonDemo_Click (object sender, EventArgs e) {

            startTetris("Default");

        }

        private void buttonHelp_Click (object sender, EventArgs e) {

            Hide();
            InfoPage infPage = new InfoPage();
            infPage.ShowDialog();
            Close();

        }

        private void buttonLoggin_Click (object sender, EventArgs e) {

            if (userTxt.Text != "" || pswTxt.Text != "") {

                SqlConnection conexion = new SqlConnection(conexionString);
                conexion.Open();
                string existsAdmin = "Select * from Users where users = '" + userTxt.Text + "' and psw = '" + encryptClass.Encrypt(pswTxt.Text) + "';";
                SqlCommand checkExistsUser = new SqlCommand(existsAdmin, conexion);

                // If user exists, start Tetris.
                try {

                    SqlDataReader reader = checkExistsUser.ExecuteReader();

                    if (reader.Read()) { startTetris(userTxt.Text); }
                    else { MessageBox.Show("User doesn't exists or password is incorrect."); }

                }

                // Else, run Exception.
                catch (Exception ex) {

                    MessageBox.Show("Error when querying the BBDD: " + ex.Message + ".");

                }
                
                conexion.Close();

            }
            

        }

        private void buttonRegister_Click (object sender, EventArgs e) {

            Hide();
            RegistrationPage regPage = new RegistrationPage();
            regPage.ShowDialog();
            Close();

        }

    }

}
