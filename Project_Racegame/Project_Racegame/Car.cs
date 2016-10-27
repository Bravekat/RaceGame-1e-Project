using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Racegame
{
    public delegate void CarUpdate(EventArgs e);

    class Car
    {
        public event CarUpdate carUpdate;
        public Transform carTransform = new Transform(250, 250);
        public bool up, right, left, down = false;
        public float movespeed = 0.07f;
        public float rotatespeed = 30;

        public Car()
        {
            carUpdate += new CarUpdate(Update);
        }

        public void Update(EventArgs e)
        {

        }

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
