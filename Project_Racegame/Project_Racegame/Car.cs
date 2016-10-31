using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Racegame
{
    public class Car
    {
        public Transform carTransform;
        public bool up, right, left, down = false;
        public float movespeedup = 0.02f;
        public float movespeeddown = 0.01f;
        public float movespeedforward = 0.1f;
        public float movespeedbackward = 0.05f;
        public float speed = 0f;
        public float rotatespeed = 20;
        public float engergie = 100;
        public int player;

        public Car(int newPlayer)
        {
            player = newPlayer;
            carTransform = new Transform(0, 0);
        }

        public Car(int newPlayer, float xPos, float yPos)
        {
            player = newPlayer;
            carTransform = new Transform(xPos, yPos);
        }

        public void Modifyspeed (float movespeedup1, float movespeeddown1, float movespeedforward1, float movespeedbackward1, float speed1)
        {
            movespeedup = movespeedup1;
            movespeeddown = movespeeddown1;
            movespeedforward = movespeedforward1;
            movespeedbackward = movespeedbackward1;
            speed = speed1;
        }

        public void ColorCollision(Bitmap colorMap, Label label)
        {
            Color pixel = colorMap.GetPixel((int)Math.Round(carTransform.position.posX), (int)Math.Round(carTransform.position.posY));
            label.Text = "" + pixel.ToArgb();

            if (pixel.ToArgb() != -1)
            {
                carTransform.Move(-0.1f);
            }
        }

        public void KeyPress(KeyEventArgs e)
        {
            if (player == 1)
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

            if (player == 2)
            {
                if (e.KeyCode == Keys.W)
                {
                    up = true;
                }
                if (e.KeyCode == Keys.D)
                {
                    right = true;
                }
                if (e.KeyCode == Keys.A)
                {
                    left = true;
                }
                if (e.KeyCode == Keys.S)
                {
                    down = true;
                }
            }
        }

        public void KeyRelease(KeyEventArgs e)
        {
            if (player == 1)
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

            if (player == 2)
            {
                if (e.KeyCode == Keys.W)
                {
                    up = false;
                }
                if (e.KeyCode == Keys.D)
                {
                    right = false;
                }
                if (e.KeyCode == Keys.A)
                {
                    left = false;
                }
                if (e.KeyCode == Keys.S)
                {
                    down = false;
                }
            }
        }
    }
}
