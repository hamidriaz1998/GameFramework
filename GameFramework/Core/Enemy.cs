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
            Game.GetInstance().AddGameObject(FireImage, Pb.Top, Pb.Left, new BulletMovement(15, FireDirection), GameObjectType.EnemyBullet);
        }
    }
}
