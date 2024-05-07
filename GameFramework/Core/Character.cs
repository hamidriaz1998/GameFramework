using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFramework.Core
{
    public class Character:GameObject
    {
        ProgressBar HealthBar { get; set; }
        Label Label;

        public Character(Image img, int top, int left, IMovement controller, GameObjectType type,ProgressBar HealthBar, Label label) : base(img, top, left, controller, type)
        {
            this.HealthBar = HealthBar;
            this.Label = label;
            HealthBar.Value = 100;
        }
        public void DecreaseHealth(int points)
        {
            if (HealthBar.Value - points <= 0)
                HealthBar.Value = 0;
            else
                HealthBar.Value -= points;
        }
        public void IncreaseHealth(int points)
        {
            if (HealthBar.Value + points >= 100)
                HealthBar.Value = 100;
            else
                HealthBar.Value += points;
        }
        public void UpdateLabelText(string text)
        {
            Label.Text = text;
        }
    }
}
