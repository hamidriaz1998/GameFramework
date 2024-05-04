using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameFramework
{
    public class HorizontalPatrol : IMovement
    {
        private int Speed;
        private Point Boundary;
        private Directions Direction;
        private int Offset = 115;
        public HorizontalPatrol(int speed, Point boundary, Directions direction)
        {
            Speed = speed;
            Boundary = boundary;
            Direction = direction;
        }
        public Point Move(Point location)
        {
            if ((location.X + Offset) >= Boundary.X)
            {
                Direction = Directions.Left;
            }
            else if (location.X - Speed <= 0)
            {
                Direction = Directions.Right;
            }
            if (Direction == Directions.Right)
            {
                location.X += Speed;
            }
            else
            {
                location.X -= Speed;
            }
            return location;
        }

    }
}
