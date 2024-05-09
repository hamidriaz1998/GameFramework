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
            game = Game.GetInstance(this,Boundary);
            // Add Game Characters
            game.AddPlayer(Resources.finalship, 880,840,new KeyboardHandler(5,Boundary),PlayerHealth,PlayerLabel,Resources.VerticalFire);
            game.AddEnemy(Resources.finalred,50,840,new HorizontalPatrol(4,Boundary,Directions.Left), RedHealth,RedLabel,Resources.VerticalFire,Directions.Down);
            game.AddEnemy(Resources.FinalEnemy,50,1800,new VerticalPatrol(4,Boundary,Directions.Down),BlueHealth,BlueLabel,Resources.HorizontalFire, Directions.Left);
            game.AddEnemy(Resources.finalgreen,50,200,new Teleportation(Boundary),GreenHealth,GreenLabel,Resources.VerticalFire,Directions.Down);
            // Add Collisions
            // Increase Enemy Health when they collide with each other
            game.AddCollsion(GameObjectType.Enemy, GameObjectType.Enemy, CollisionAction.IncreaseHealth);
            // Decrease Health of both player and enemy when they collide
            game.AddCollsion(GameObjectType.Player,GameObjectType.Enemy,CollisionAction.DecreaseHealth);
            // Decrease enemy health and increase player score on collision with player bullet
            game.AddCollsion(GameObjectType.PlayerBullet, GameObjectType.Enemy, CollisionAction.IncreaseScore);
            game.AddCollsion(GameObjectType.PlayerBullet, GameObjectType.Enemy, CollisionAction.DecreaseHealth);
            // Decrease player health and score on collision with enmey bullet
            game.AddCollsion(GameObjectType.EnemyBullet, GameObjectType.Player, CollisionAction.DecreaseScore);
            game.AddCollsion(GameObjectType.EnemyBullet, GameObjectType.Player, CollisionAction.DecreaseHealth);
        }

        private void GameLoop_Tick(object sender, EventArgs e)
        {
            game.Update();
            ScoreLabel.Text = "Score: " + game.GetScore();
            if (game.IsGameOver())
            {
                GameLoop.Enabled = false;
                MessageBox.Show("Your Score: " + game.GetScore());
                Application.Exit();
            }
        }
    }
}
