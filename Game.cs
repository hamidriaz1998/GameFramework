using System;
using System.Collections.Generic;
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
        public Game(Form form,int gravity)
        {
            GameForm = form;
            Gravity = gravity;
        }
    }
}
