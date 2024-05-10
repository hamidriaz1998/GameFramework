using System.Drawing;
using System.Windows.Forms;

namespace GameFramework
{
    public class GameObject
    {
        internal PictureBox Pb { get; set; }
        private IMovement Controller;
        internal GameObjectType Type { get; set; }
        public GameObject(Image img, int top, int left, IMovement controller, GameObjectType type)
        {
            Pb = new PictureBox
            {
                Image = img,
                Top = top,
                Left = left,
                BackColor = Color.Transparent,
                Width = img.Width,
                Height = img.Height
            };
            Controller = controller;
            Type = type;
        }
        public void Update()
        {
            Pb.Location = Controller.Move(Pb.Location);
        }
    }
}
