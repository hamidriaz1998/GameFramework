using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework
{
    public class VerticalPatrol : IMovement
    {
        private int Speed;
        private Point Boundary;
        private Directions Direction;
        private int Offset = 90;
        public VerticalPatrol(int speed, Point boundary, Directions direction)
        {
            Speed = speed;
            Boundary = boundary;
            Direction = direction;
        }
        public Point Move(Point location)
        {
            if ((location.Y + Offset) >= Boundary.Y)
            {
                Direction = Directions.Up;
            }
            else if (location.Y - Speed <= 0)
            {
                Direction = Directions.Down;
            }
            if (Direction == Directions.Down)
            {
                location.Y += Speed;
            }
            else
            {
                location.Y -= Speed;
            }
            return location;
        }
    }
}
