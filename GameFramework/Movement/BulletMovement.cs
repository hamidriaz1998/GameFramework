using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Movement
{
    internal class BulletMovement : IMovement
    {
        private int Speed;
        private Directions Direction;
        public BulletMovement(int speed, Directions direction)
        {
            Speed = speed;
            Direction = direction;
        }
        public Point Move(Point location)
        {
            if (Direction == Directions.Up)
            {
                location.Y -= Speed;
            }
            else if (Direction == Directions.Down)
            {
                location.Y += Speed;
            }
            else if (Direction == Directions.Left)
            {
                location.X -= Speed;
            }
            else
            {
                location.X += Speed;
            }
            return location;
        }
    }
}
