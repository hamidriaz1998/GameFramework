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
            // Set Form Properties
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.BackgroundImage = Resources.afds;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            // Intialize Game Instance
            Boundary = new Point(this.Width - 25 , this.Height - 70);
            game = Game.GetInstance(this);
            // Add Game Characters
            game.AddCharacter(Resources.finalship, 880,840,new KeyboardHandler(5,Boundary), GameObjectType.Player,PlayerHealth,PlayerLabel);
            game.AddCharacter(Resources.finalred,50,840,new HorizontalPatrol(5,Boundary,Directions.Left), GameObjectType.Enemy,RedHealth,RedLabel);
            game.AddCharacter(Resources.FinalEnemy,50,1800,new VerticalPatrol(5,Boundary,Directions.Down), GameObjectType.Enemy,BlueHealth,BlueLabel);
            game.AddCharacter(Resources.finalgreen,50,200,new Teleportation(Boundary), GameObjectType.Enemy,GreenHealth,GreenLabel);
            // Add Collisions
            game.AddCollsion(GameObjectType.Enemy, GameObjectType.Enemy, CollisionAction.IncreaseHealth);
            game.AddCollsion(GameObjectType.Player,GameObjectType.Enemy,CollisionAction.DecreaseHealth);
        }

        private void GameLoop_Tick(object sender, EventArgs e)
        {
            game.Update();
            ScoreLabel.Text = "Score: " + game.GetScore();
        }
    }
}
