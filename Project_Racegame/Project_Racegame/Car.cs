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
        public float energie = 100;
        public int aantalpitstops = 0;
        public bool checkpoint1 = false;
        public bool checkpoint2 = false;
        public bool checkpoint3 = false;
        public int ronde = 0;
        public bool finish = false;
        public int player;

        public Car(int newPlayer, Bitmap image)
        {
            player = newPlayer;
            carTransform = new Transform(0, 0, image);
        }

        public Car(int newPlayer, int height, int width)
        {
            player = newPlayer;
            carTransform = new Transform(0, 0, new Point(height, width));
        }

        public Car(int newPlayer, float xPos, float yPos, Bitmap image)
        {
            player = newPlayer;
            carTransform = new Transform(xPos, yPos, image);
        }

        public Car(int newPlayer, float xPos, float yPos, int height, int width)
        {
            player = newPlayer;
            carTransform = new Transform(xPos, yPos, new Point(height, width));
        }

        public void Modifyspeed (float movespeedup1, float movespeeddown1, float movespeedforward1, float movespeedbackward1, float speed1)
        {
            movespeedup = movespeedup1;
            movespeeddown = movespeeddown1;
            movespeedforward = movespeedforward1;
            movespeedbackward = movespeedbackward1;
            speed = speed1;
        }

        public void ColorCollision(Bitmap colorMap, Label label, Label labelspeed, Label labelpitstop, Label labeltest)
        {
            Point anchor = new Point((int)carTransform.position.posX + ((int)carTransform.size.width / 4), (int)carTransform.position.posY + ((int)carTransform.size.height / 3));
            Color pixel = colorMap.GetPixel(anchor.X, anchor.Y);
            label.Text = "RONDE:" + ronde;
            labelspeed.Text = "SNELHEID:" + speed;
            labelpitstop.Text = "AANTAL PITSTOPS:" + aantalpitstops;
            labeltest.Text = "" + pixel.ToArgb();

            if (pixel.ToArgb() == -5502435) //rozerand-rechts
            {
                carTransform.position.posX -= 25;
            }
            if (pixel.ToArgb() == -15687917) //groenerand-links
            {
                carTransform.position.posX += 25;
            }
            if (pixel.ToArgb() == -15392057) //blauwerand-boven
            {
                carTransform.position.posY += 25;
            }
            if (pixel.ToArgb() == -7661363) //paarserand-onder
            {
                carTransform.position.posY -= 25;
            }
            if (pixel.ToArgb() == -256) //pitstop-geel
            {
                if (energie < 80)
                {
                    energie = 100;
                    aantalpitstops += 1;
                    movespeedup = 0.02f;
                    movespeeddown = 0.01f;
                    movespeedforward = 0.1f;
                    movespeedbackward = 0.05f;
                }
            }
            if (pixel.ToArgb() == -5350137) //checkpoint1
            {
                checkpoint1 = true;
            }
            if (pixel.ToArgb() == -43776) //checkpoint2
            {
                if(checkpoint1 == true)
                {
                    checkpoint2 = true;
                }
            }
            if (pixel.ToArgb() == -16715521) //checkpoint3
            {
                if (checkpoint1 == true && checkpoint2 == true)
                {
                    checkpoint3 = true;
                }
            }
            if (pixel.ToArgb() == -7237231) //finish/ronde
            {
                if (checkpoint1 == true && checkpoint2 == true && checkpoint2 == true)
                {
                    ronde = ronde + 1;
                    checkpoint1 = false;
                    checkpoint2 = false;
                    checkpoint3 = false;
                }
            }
            if (pixel.ToArgb() == -16777216) //vanparkoers-zwart
            {
                movespeedup = 0.01f;
                movespeeddown = 0.005f;
                movespeedforward = 0.05f;
                movespeedbackward = 0.025f;
            }
            if (pixel.ToArgb() == -1) //opparkoers-wit
            {
                movespeedup = 0.02f;
                movespeeddown = 0.01f;
                movespeedforward = 0.1f;
                movespeedbackward = 0.05f;
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
