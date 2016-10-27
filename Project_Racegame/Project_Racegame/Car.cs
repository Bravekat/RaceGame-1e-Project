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
        public float movespeedup = 0.02f;
        public float movespeeddown = 0.01f;
        public float movespeedforward = 0.1f;
        public float movespeedbackward = 0.05f;
        public float speed = 0f;
        public float rotatespeed = 20;

        public Car()
        {
            carUpdate += new CarUpdate(Update);
        }

        public void Update(EventArgs e)
        {

        }

        public void Modifyspeed (float movespeedup1, float movespeeddown1, float movespeedforward1, float movespeedbackward1, float speed1)
        {
            movespeedup = movespeedup1;
            movespeeddown = movespeeddown1;
            movespeedforward = movespeedforward1;
            movespeedbackward = movespeedbackward1;
            speed = speed1;
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
