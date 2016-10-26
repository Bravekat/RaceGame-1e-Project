using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Racegame
{
    class Car
    {
        public Transform carTransform = new Transform(250, 250);
        int movespeed = 10;
        int speedrotate = 1;

        public void KeyPress(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                carTransform.Move(movespeed);
                if (e.KeyCode == Keys.Right)
                {
                    carTransform.Move(movespeed, speedrotate);
                }
                if (e.KeyCode == Keys.Left)
                {
                    carTransform.Move(movespeed, -speedrotate);
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                carTransform.Move(-movespeed);
                if (e.KeyCode == Keys.Right)
                {
                    carTransform.Move(-movespeed, -speedrotate);
                }
                if (e.KeyCode == Keys.Left)
                {
                    carTransform.Move(-movespeed, speedrotate);
                }
            }
        }
    }
}
