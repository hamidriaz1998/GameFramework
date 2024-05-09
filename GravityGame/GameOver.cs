using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GravityGame
{
    public partial class GameOver : Form
    {
        int Score;
        public GameOver(int score)
        {
            InitializeComponent();
            Score = score;
        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Form1();
            form.ShowDialog();
            this.Close();
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new MainMenu();
            form.ShowDialog(); 
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            ScoreLabel.Text += Score;
        }
    }
}
