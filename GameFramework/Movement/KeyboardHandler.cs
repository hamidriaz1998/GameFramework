﻿using System;
using EZInput;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Configuration;
using GameFramework.Core;

namespace GameFramework
{
    public class KeyboardHandler:IMovement
    {
        private int Speed;
        private System.Drawing.Point Boundary;
        private int OffsetY = 90;
        private int OffsetX = 115;
        private Player Player;

        public KeyboardHandler(int speed, System.Drawing.Point boundary)
        {
            Speed = speed;
            Boundary = boundary;
        }
        public void SetPlayer(Player player) {  Player = player; }
        public System.Drawing.Point Move(System.Drawing.Point location)
        {
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                Player.Fire();
            }
            if (Keyboard.IsKeyPressed(Key.W))
            {
                if (location.Y - Speed <= 50)
                {
                    location.Y = 50;
                }
                else
                {
                    location.Y -= Speed;
                }
            }
            else if (Keyboard.IsKeyPressed(Key.S))
            {
                if ((location.Y + OffsetY) >= Boundary.Y)
                {
                    location.Y = Boundary.Y - OffsetY;
                }
                else
                {
                    location.Y += Speed;
                }
            }
            else if (Keyboard.IsKeyPressed(Key.A))
            {
                if (location.X - Speed <= 0)
                {
                    location.X = 0;
                }
                else
                {
                    location.X -= Speed;
                }
            }
            else if (Keyboard.IsKeyPressed(Key.D))
            {
                if ((location.X + OffsetX) >= Boundary.X)
                {
                    location.X = Boundary.X - OffsetX;
                }
                else
                {
                    location.X += Speed;
                }
            }
            return location;
        }
    }

}
