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
        float movespeed = 0.07f;
        int speedrotate = 10;

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
