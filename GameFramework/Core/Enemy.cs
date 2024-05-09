using GameFramework.Movement;
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
        private Directions FireDirection;
        public Enemy(Image img, int top, int left, IMovement controller, ProgressBar HealthBar, Label label, Image fireImage, Directions fireDirection) : base(img, top, left, controller, GameObjectType.Enemy, HealthBar, label, fireImage)
        {
            FireDirection = fireDirection;
        }
        public override void Fire()
        {
            int FireTop = Pb.Top, FireLeft = Pb.Left;
            if (FireDirection == Directions.Down)
            {
                FireTop += 30;
                FireLeft += 40;
            }
            else
            {
                FireTop += 40;
                FireLeft -= 20;
            }
            Game.GetInstance().AddGameObject(FireImage, FireTop, FireLeft, new BulletMovement(10, FireDirection), GameObjectType.EnemyBullet);
        }
    }
}
