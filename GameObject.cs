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
        private PictureBox Pb;
        public bool gravity;
        public PictureBox GetPb()
        {
            return Pb;
        }
        public GameObject(Image img, int top, int left)
        {
            Pb = new PictureBox
            {
                Image = img,
                Top = top,
                Left = left,
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
        }
        public virtual void move(int gravity)
        {
            Pb.Top += gravity;
        }
    }
}
