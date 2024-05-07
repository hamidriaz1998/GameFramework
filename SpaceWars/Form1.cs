using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameFramework;

namespace SpaceWars
{
    public partial class Form1 : Form
    {
        private Game game;
        private Point Boundary;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            Boundary = new Point(this.Width, this.Height);
            game = Game.GetInstance(this);
        }

        private void GameLoop_Tick(object sender, EventArgs e)
        {
            game.Update();
        }
    }
}
