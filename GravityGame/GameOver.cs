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
            ScoreLabel.Text += Score.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
