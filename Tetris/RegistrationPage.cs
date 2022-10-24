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


    public partial class RegistrationPage : Form {
        
        static readonly string conexionString = "Server = 42-ARRUFI\\SQLEXPRESS; database = TetrisGame; integrated security = True";

        // Call private class Encrypt.
        EncryptClass encryptClass = new EncryptClass();

        private void startTetris(string registredUser) {

            Hide();
            MainWindow main = new MainWindow(true, registredUser);
            main.ShowDialog();
            Close();

        }

        public RegistrationPage () {

            InitializeComponent();

        }

        private void pswRegTxt_TextChanged (object sender, EventArgs e) {

        }

        private void buttonBack_Click (object sender, EventArgs e) {
            
            Hide();
            StartPage startPage = new StartPage();
            startPage.ShowDialog();
            Close();

        }

        private bool checkExistsUser(string user) {

            bool result = true;
            SqlConnection conexion = new SqlConnection (conexionString);
            conexion.Open ();
            string existsAdmin = "Select * from Users where users = '" + user + "'";
            SqlCommand checkExistsUser = new SqlCommand(existsAdmin, conexion);

            // If user exists, return True.
            try {

                SqlDataReader reader = checkExistsUser.ExecuteReader();
                if (!reader.Read()) { result = false; }

            }

            catch (Exception ex) {

                MessageBox.Show ("Error when querying the BBDD: " + ex.Message + ".");

            }

            conexion.Close();
            return result;

        }

        private void buttonRegistration_Click (object sender, EventArgs e) {

            if (userRegTxt.Text != "" || pswRegTxt.Text != "") {

                if (checkExistsUser(userRegTxt.Text)) {

                    MessageBox.Show("User exists in the BBDD.");

                }

                else {
                    
                    SqlConnection conexion = new SqlConnection (conexionString);
                    conexion.Open ();
                    string registrationSqlCommand = "INSERT INTO Users VALUES ('" + userRegTxt.Text + "', '" + encryptClass.Encrypt(pswRegTxt.Text) + "');";
                    SqlCommand registrationUser = new SqlCommand(registrationSqlCommand, conexion);

                    try {

                        SqlDataReader reader = registrationUser.ExecuteReader();
                        startTetris(userRegTxt.Text);

                    }

                    catch (Exception ex) {

                        MessageBox.Show("Error when put the user into the BBDD: " + ex.Message + ".");

                    }

                    conexion.Close();

                }

            }

        }

    }

}
