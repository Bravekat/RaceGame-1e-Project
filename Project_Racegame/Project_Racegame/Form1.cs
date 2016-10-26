using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Racegame
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        Bitmap Backbuffer;
        Car car = new Car();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Red, car.carTransform.position.posX, car.carTransform.position.posY, 10, 10);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "X position: " + car.carTransform.position.posX;
            label2.Text = "Y position: " + car.carTransform.position.posY;
            label3.Text = "X rotation: " + car.carTransform.rotation.rotX;
            label4.Text = "Y rotation: " + car.carTransform.rotation.rotY;
            if (car.up == true)
            {
                car.carTransform.Move(car.movespeed);
                if (car.right == true)
                {
                    car.carTransform.Move(car.movespeed, car.rotatespeed);
                }
                if (car.left == true)
                {
                    car.carTransform.Move(car.movespeed, -car.rotatespeed);
                }
            }
            if(car.down == true)
            {
                car.carTransform.Move(-car.movespeed);
                if (car.right == true)
                {
                    car.carTransform.Move(-car.movespeed, -car.rotatespeed);
                }
                if (car.left == true)
                {
                    car.carTransform.Move(-car.movespeed, car.rotatespeed);
                }
            }
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            car.KeyPress(e);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            car.KeyRelease(e);
        }
    }
}
