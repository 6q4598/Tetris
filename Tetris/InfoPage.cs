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
    public partial class InfoPage : Form {
        public InfoPage () {
            InitializeComponent();
        }

        private void label1_Click (object sender, EventArgs e) {

        }

        private void buttonBack_Click (object sender, EventArgs e) {

            Hide();
            StartPage startPage = new StartPage();
            startPage.ShowDialog();
            Close();

        }

    }

}
