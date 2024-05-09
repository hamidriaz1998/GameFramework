using GameFramework.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GameFramework
{
    public class Game
    {
        private int Score;
        private Point Boundary;
        private Form GameForm;
        private List<GameObject> GameObjects;
        private List<CollisionDetection> CollisionDetections;
        private Random FireTurn = new Random();
        // Singleton pattern
        private static Game Instance;
        public static Game GetInstance(Form form, Point boundary)
        {
            if (Instance == null)
            {
                Instance = new Game(form,boundary);
            }
            return Instance;
        }
        internal static Game GetInstance()
        {
            return Instance;
        }
        // Private constructor
        private Game(Form form,Point boundary)
        {
            GameForm = form;
            GameObjects = new List<GameObject>();
            CollisionDetections = new List<CollisionDetection>();
            Boundary = boundary;
            Score = 0;
        }
        // Methods
        public void AddGameObject(Image image, int top, int left, IMovement controller, GameObjectType type)
        {
            if (type == GameObjectType.PlayerBullet && GetGameObjectCount(GameObjectType.PlayerBullet) > 5)
            {
                return;
            }
            if (type == GameObjectType.EnemyBullet && GetGameObjectCount(GameObjectType.EnemyBullet) > 5)
            {
                return;
            }
            GameObject go = new GameObject(image, top, left,controller,type);
            GameObjects.Add(go);
            GameForm.Controls.Add(go.Pb);
        }
        public void AddEnemy(Image image, int top, int left, IMovement controller, ProgressBar healthBar, Label label,Image FireImage, Directions fireDirection)
        {
            Enemy character = new Enemy(image, top, left, controller, healthBar,label,FireImage,fireDirection);
            GameObjects.Add(character);
            GameForm.Controls.Add(character.Pb);
        }
        public void AddPlayer(Image image, int top, int left, IMovement controller, ProgressBar healthBar, Label label,Image FireImage)
        {
            Player player = new Player(image, top, left, controller, healthBar, label, FireImage);
            GameObjects.Add(player);
            GameForm.Controls.Add(player.Pb);
        }
        public int GetGameObjectCount()
        {
            return GameObjects.Count;
        }
        public int GetGameObjectCount(GameObjectType type)
        {
            return GameObjects.Count(go => go.Type == type);
        }
        public void AddCollsion(GameObjectType type1, GameObjectType type2, CollisionAction action)
        {
            CollisionDetection cd = new CollisionDetection(type1, type2, action);
            CollisionDetections.Add(cd);
        }
        public void RemoveGameObject(GameObject gameObject)
        {
            GameObjects.Remove(gameObject);
            GameForm.Controls.Remove(gameObject.Pb);
        }
        public int GetScore() { return Score; }
        public void IncreaseScore(int points) { Score += points; }
        private void EnemyFire()
        {
            var enemies = GameObjects.Where(go => go.Type == GameObjectType.Enemy).ToList().Cast<Enemy>();
            foreach (var enemy in enemies)
            {
                if (FireTurn.Next(1, 15)  == 7)
                {
                    enemy.Fire();
                    break;
                }
            }
        }
        private void RemoveOutOfBoundsBullets()
        {
            var bullets = GameObjects.Where(go => go.Type == GameObjectType.PlayerBullet || go.Type == GameObjectType.EnemyBullet).ToList();
            foreach(var bullet in bullets)
            {
                var location = bullet.Pb.Location;
                if (location.X <= 0 || location.Y <= 0 || location.Y >= Boundary.Y || location.X >= Boundary.X)
                {
                    RemoveGameObject(bullet);
                }
            }
        }
        private void RemoveDeadEnemies()
        {
            var enemies = GameObjects.Where(go => go.Type == GameObjectType.Enemy).ToList().Cast<Enemy>();
            foreach(var enemy in enemies)
            {
                if (enemy.GetHealth() == 0)
                {
                    enemy.UpdateLabelText("Dead");
                    RemoveGameObject(enemy);
                    Score += 50;
                }
            }
        }
        public void Update()
        {
            for(int i = 0;i<GameObjects.Count;i++)
            {
                GameObjects[i].Update();
            }
            EnemyFire();
            foreach (var cd in CollisionDetections)
            {
                cd.CheckCollision(GameObjects);
            }
            RemoveOutOfBoundsBullets();
            RemoveDeadEnemies();
        }

        internal void DecreaseScore(int points)
        {
            if (Score - points <= 0)
                Score = 0;
            else
                Score -= points;
        }
    }
}
