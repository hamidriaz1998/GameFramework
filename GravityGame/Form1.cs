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
using GravityGame.Properties;

namespace GravityGame
{
    public partial class Form1 : Form
    {
        Game game;
        private Point Boundary;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.BackgroundImage = Resources.afds;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            Boundary = new Point(this.Width - 25 , this.Height - 70);
            game = Game.GetInstance(this);
            game.AddGameObject(Resources.finalship, 880,840,new KeyboardHandler(15,Boundary), GameObjectType.Player);
            game.AddGameObject(Resources.finalred,50,840,new HorizontalPatrol(8,Boundary,Directions.Left), GameObjectType.Enemy);
        }

        private void GameLoop_Tick(object sender, EventArgs e)
        {
            game.Update();
        }
    }
}
