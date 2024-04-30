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
        internal PictureBox Pb { get => Pb; set => Pb = value; }
        IMovement Controller;
        public PictureBox GetPb()
        {
            return Pb;
        }
        public GameObject(Image img, int top, int left, IMovement controller)
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
        }
        public void Update()
        {
            Pb.Location = Controller.Move(Pb.Location);
        }
    }
}
