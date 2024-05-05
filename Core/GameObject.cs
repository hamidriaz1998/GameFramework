using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFramework
{
    public class GameObject
    {
        internal PictureBox Pb { get; set; }
        private IMovement Controller;
        internal GameObjectType Type { get; set; }
        private int Health;
        private int Score;
        public GameObject(Image img, int top, int left, IMovement controller, GameObjectType type)
        {
            Pb = new PictureBox
            {
                Image = img,
                Top = top,
                Left = left,
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            Controller = controller;
            Type = type;
            Health = 100;
        }
        public int GetHealth()
        {
            return Health;
        }
        public void DecreaseHealth(int points)
        {
            if (Health - points <= 0)
                Health = 0;
            else
                Health -= points;
        }
        public void IncreaseHealth(int points)
        {
            if (Health + points >= 100)
                Health = 100;
            else
                Health += points;
        }
        public void Update()
        {
            Pb.Location = Controller.Move(Pb.Location);
        }
    }
}
