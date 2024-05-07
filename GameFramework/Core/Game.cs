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
        private Form GameForm;
        private List<GameObject> GameObjects;
        private List<CollisionDetection> CollisionDetections;
        // Singleton pattern
        private static Game Instance;
        public static Game GetInstance(Form form)
        {
            if (Instance == null)
            {
                Instance = new Game(form);
            }
            return Instance;
        }
        // Private constructor
        private Game(Form form)
        {
            GameForm = form;
            GameObjects = new List<GameObject>();
            CollisionDetections = new List<CollisionDetection>();
        }
        // Methods
        public void AddGameObject(Image image, int top, int left, IMovement controller, GameObjectType type)
        {
            GameObject go = new GameObject(image, top, left,controller,type);
            GameObjects.Add(go);
            GameForm.Controls.Add(go.Pb);
        }
        public void AddGameObject(Image image, int top, int left, IMovement controller, GameObjectType type, ProgressBar healthBar, Label label)
        {
            Character character = new Character(image, top, left, controller, type,healthBar,label);
            GameObjects.Add((GameObject)character);
            GameForm.Controls.Add(character.Pb);
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
        public void Update()
        {
            foreach(GameObject go in GameObjects)
            {
                go.Update();     
            }
            foreach (var cd in CollisionDetections)
            {
                cd.CheckCollision(GameObjects);
            }
        }
    }
}
