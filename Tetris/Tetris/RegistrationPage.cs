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

    public partial class RegistrationPage : Form {

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

        private void buttonRegistration_Click (object sender, EventArgs e) {

            Console.WriteLine("Hello World");

            if (userRegTxt.Text != "" || pswRegTxt.Text != "") {

                if (userRegTxt.Text == "admin" && pswRegTxt.Text == "1234") {
                    
                    Hide();
                    MainWindow main = new MainWindow(true);
                    main.ShowDialog();
                    Close();

                }

            }

        }

    }

}
