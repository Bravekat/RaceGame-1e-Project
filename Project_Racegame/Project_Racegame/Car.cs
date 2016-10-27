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
        public bool up, right, left, down = false;
        public float movespeedup = 0.02f;
        public float movespeeddown = 0.01f;
        public float rotatespeed = 30;
        public float movespeedforward = 0.1f;
        public float movespeedbackward = 0.05f;
        public float speed = 0f;

        public void KeyPress(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                up = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                down = true;
            }
        }

        public void KeyRelease(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                up = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                down = false;
            }
        }
    }
}
