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
        private List<PictureBox> GravityObjects;
        public Game(Form form,int gravity)
        {
            GameForm = form;
            Gravity = gravity;
            GravityObjects = new List<PictureBox>();
        }
        public void addGameObject(Image image, int top, int left, bool gravity)
        {
            PictureBox picture = new PictureBox();
            picture.Image = image;
            picture.Top = top;
            picture.Left = left;
            picture.BackColor = Color.Transparent;
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            GameForm.Controls.Add(picture);
            if (gravity)
            {
                GravityObjects.Add(picture);
            }
        }
        public void update()
        {
            foreach (PictureBox picture in GravityObjects)
            {
                picture.Top += Gravity;
            }
        }
    }
}
