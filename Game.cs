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
        private List<GameObject> gameObjects;
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
            gameObjects = new List<GameObject>();
        }
        // Methods
        public void addGameObject(Image image, int top, int left, IMovement controller)
        {
            GameObject go = new GameObject(image, top, left,controller);
            gameObjects.Add(go);
            GameForm.Controls.Add(go.Pb);
        }
        public void update()
        {
            foreach(var go in gameObjects)
            {
                go.Update();     
            }
        }
    }
}
