using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack {
    public partial class HelpForm : Form {
        public HelpForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            StartGame startGame = new StartGame();
            this.Hide();
            startGame.Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            MainMenu menu = new MainMenu();
            this.Hide();
            menu.Show();

        }
    }
}
