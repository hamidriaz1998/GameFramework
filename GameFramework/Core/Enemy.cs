using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFramework.Core
{
    internal class Enemy : Character
    {
        public Enemy(Image img, int top, int left, IMovement controller, GameObjectType type, ProgressBar HealthBar, Label label, Image fireImage) : base(img, top, left, controller, type, HealthBar, label, fireImage)
        {
        }
        public override void Fire()
        {
            throw new NotImplementedException();
        }
    }
}
