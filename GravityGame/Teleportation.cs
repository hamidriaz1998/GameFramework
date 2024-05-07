using GameFramework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravityGame
{
    public class Teleportation : IMovement
    {
        private Point Boundary;
        private Random Random;
        private DateTime LastTeleportTime;
        private TimeSpan TeleportDelay;
        public Teleportation(Point boundary)
        {
            this.Boundary = boundary;
            Random = new Random();
            LastTeleportTime = DateTime.Now;
            TeleportDelay = TimeSpan.FromSeconds(2);
        }
        public Point Move(Point location)
        {
            if (DateTime.Now - LastTeleportTime >= TeleportDelay)
            {
                int x = Random.Next(0, Boundary.X - 40);
                int y = Random.Next(50, Boundary.Y - 45);
                location = new Point(x, y);
                LastTeleportTime = DateTime.Now;
            }
            return location;
        }
    }
}