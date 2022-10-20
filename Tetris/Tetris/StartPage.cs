using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris {

    public partial class StartPage : Form {

        public StartPage () {

            InitializeComponent();

        }

        private void startTetris() {

            Hide();
            MainWindow main = new MainWindow(true);
            main.ShowDialog();
            Close();

        }

        private void buttonDemo_Click (object sender, EventArgs e) {

            startTetris();

        }

        private void buttonHelp_Click (object sender, EventArgs e) {

        }

        private void buttonLoggin_Click (object sender, EventArgs e) {

            if (userTxt.Text != String.Empty || pswTxt.Text != String.Empty) {

                if (userTxt.Text == "admin" && pswTxt.Text == "1234") {

                    startTetris();

                }

            }

            else {


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
