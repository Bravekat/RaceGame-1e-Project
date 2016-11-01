﻿using System;
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
        Bitmap colorMap;
        Bitmap player1 = Properties.Resources.Zombie_animation_1_1;
        Bitmap player2 = Properties.Resources.Zombie_animation_1_1;
        Car car1;
        Car car2;

        public Form1()
        {
            InitializeComponent();
            BackgroundImage = Properties.Resources.Ztracks1_colormap;
            colorMap = Properties.Resources.Ztracks1_colormap;
            car1 = new Car(1, 30, 500, player1);
            car2 = new Car(2, 70, 500, player2);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap(Properties.Resources.Zombie_animation_1_1), car1.carTransform.position.posX, car1.carTransform.position.posY, 32, 46);
            e.Graphics.DrawImage(new Bitmap(Properties.Resources.Zombie_animation_1_1), car2.carTransform.position.posX, car2.carTransform.position.posY, 32, 46);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            car1.ColorCollision(colorMap, label3, label5, label7);
            car2.ColorCollision(colorMap, label4, label6, label8);
            this.label1.Text = "ENERGIE p1: " + Math.Round(car1.energie) + "%";
            this.label2.Text = "ENERGIE p2: " + Math.Round(car2.energie) + "%";

            if (car1.up == true)
            {
                car1.carTransform.Move(car1.movespeedforward);
                car1.speed = car1.movespeedforward;
                if (car1.right == true)
                {
                    car1.carTransform.Move(car1.movespeedup, car1.rotatespeed);
                }
                if (car1.left == true)
                {
                    car1.carTransform.Move(car1.movespeedup, -car1.rotatespeed);
                }
            }
            if(car1.down == true)
            {
                car1.carTransform.Move(-car1.movespeedbackward);
                car1.speed = car1.movespeedbackward;
                if (car1.right == true)
                {
                    car1.carTransform.Move(-car1.movespeeddown, -car1.rotatespeed);
                }
                if (car1.left == true)
                {
                    car1.carTransform.Move(-car1.movespeeddown, car1.rotatespeed);
                }
            }

            if (car2.up == true)
            {
                car2.carTransform.Move(car2.movespeedforward);
                car2.speed = car2.movespeedforward;
                if (car2.right == true)
                {
                    car2.carTransform.Move(car2.movespeedup, car2.rotatespeed);
                }
                if (car2.left == true)
                {
                    car2.carTransform.Move(car2.movespeedup, -car2.rotatespeed);
                }
            }
            if (car2.down == true)
            {
                car2.carTransform.Move(-car2.movespeedbackward);
                car2.speed = car2.movespeedbackward;
                if (car2.right == true)
                {
                    car2.carTransform.Move(-car2.movespeeddown, -car2.rotatespeed);
                }
                if (car2.left == true)
                {
                    car2.carTransform.Move(-car2.movespeeddown, car2.rotatespeed);
                }
            }
            Invalidate();

            if (car1.down == false && car1.up == false)
            {
                car1.speed = 0;
            }
            if (car1.speed == car1.movespeedforward)
            {
                car1.speed = 3;
                car1.energie = car1.energie - 0.1f;
                if (car1.energie <= 1)
                {
                    car1.speed = 1;
                }
            }
            if (car1.speed == car1.movespeedbackward)
            {
                car1.speed = 2;
                car1.energie = car1.energie - 0.05f;
            }

            if (car2.down == false && car2.up == false)
            {
                car2.speed = 0;
            }
            if (car2.speed == car2.movespeedforward)
            {
                car2.speed = 3;
                car2.energie = car2.energie - 0.1f;
                if (car2.energie <= 1)
                {
                    car2.speed = 1;
                }
            }
            if (car2.speed == car2.movespeedbackward)
            {
                car2.speed = 2;
                car2.energie = car2.energie - 0.05f;
            }

            if(car1.energie <= 1)
            {
                car1.energie = 0;
                car1.movespeedup = 0.01f;
                car1.movespeeddown = 0.005f;
                car1.movespeedforward = 0.05f;
                car1.movespeedbackward = 0.025f;
            }
            if (car2.energie <= 1)
            {
                car2.energie = 0;
                car2.movespeedup = 0.01f;
                car2.movespeeddown = 0.005f;
                car2.movespeedforward = 0.05f;
                car2.movespeedbackward = 0.025f;
            }            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            car1.KeyPress(e);
            car2.KeyPress(e);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            car1.KeyRelease(e);
            car2.KeyRelease(e);
        }
    }
}
