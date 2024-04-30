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
        private int Gravity;
        private List<GameObject> gameObjects;
        public Game(Form form,int gravity)
        {
            GameForm = form;
            Gravity = gravity;
            gameObjects = new List<GameObject>();
        }
        public void addGameObject(Image image, int top, int left, IMovement controller)
        {
            GameObject go = new GameObject(image, top, left,controller);
            gameObjects.Add(go);
            GameForm.Controls.Add(go.GetPb());
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
