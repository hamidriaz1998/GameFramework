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
    public class Player : Character
    {
        public Player(Image img, int top, int left, IMovement controller, ProgressBar HealthBar, Label label, Image fireImage) : base(img, top, left, controller, GameObjectType.Player, HealthBar, label, fireImage)
        {
            var KeyController = (KeyboardHandler)controller;
            KeyController.SetPlayer(this);
        }

        public override void Fire()
        {
            Game.GetInstance().AddGameObject(FireImage, Pb.Top+15, Pb.Left+40, new BulletMovement(15, Directions.Up), GameObjectType.PlayerBullet);
        }
    }
}
