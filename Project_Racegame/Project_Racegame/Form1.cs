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
        Car car1 = new Car(1, 30, 500);
        Car car2 = new Car(2, 70, 500);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Red, car1.carTransform.position.posX, car1.carTransform.position.posY, 10, 10);
            e.Graphics.FillRectangle(Brushes.Red, car2.carTransform.position.posX, car2.carTransform.position.posY, 10, 10);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
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
                car1.energie = car1.energie - 0.2f;
            }
            if (car1.speed == car1.movespeedbackward)
            {
                car1.speed = 2;
                car1.energie = car1.energie - 0.1f;
            }

            if (car2.down == false && car2.up == false)
            {
                car2.speed = 0;
            }
            if (car2.speed == car2.movespeedforward)
            {
                car2.speed = 3;
                car2.energie = car2.energie - 0.2f;
            }
            if (car2.speed == car2.movespeedbackward)
            {
                car2.speed = 2;
                car2.energie = car2.energie - 0.1f;
            }

            if(car1.energie <= 1)
            {
                car1.energie = 0;
                car1.movespeedup = 0.01f;
                car1.movespeeddown = 0.005f;
                car1.movespeedforward = 0.05f;
                car1.movespeedbackward = 0.025f;
            }//
            if (car2.energie <= 1)
            {
                car2.energie = 0;
                car2.movespeedup = 0.01f;
                car2.movespeeddown = 0.005f;
                car2.movespeedforward = 0.05f;
                car2.movespeedbackward = 0.025f;
            }

            /*dit moet in de cases komen van de colormapping ding.
            case "car naast de baan, dus in gras ofiets dergelijks":
            {
                car1.movespeedup = 0.01f;
                car1.movespeeddown = 0.005f;
                car1.movespeedforward = 0.05f;
                car1.movespeedbackward = 0.025f;  //hetzelfde voor car2
                break;
            }
            case "car op pitstop":
            {
                if(car1.engergie<50)
                {
                    car1.energie = 100;
                    car1.aantalpitstops = car1.aantalpitstops + 1;
                }
                //hetzelfde voor car2
                break;
            }
            case "car botst tegen rand":
            {
                //hetzelfde voor car2
                break;
            }
            case "car raakt chekpoint1":
            {
                car1.chekpoint 1 == true; //hetzelfde voor car2
                break;
            }
            case "car raakt chekpoint2":
            {
                if (car1.checkpoint1==true)
                {
                    car1.chekpoint 2 = true;
                }//hetzelfde voor car2
                break;
            }
            case "car raakt chekpoint3":
            {
                if (car1.checkpoint1==true && car1.checkpoint2===true)
                {
                    car1.chekpoint 3 = true;
                }//hetzelfde voor car2
                break;
            }
            case "car raakt finish":
            {
                if (car1.checkpoint1==true && car1.checkpoint2==true && car1.checkpoint2==true)
                {
                    car1.ronde = car1.ronde + 1;
                    car1.checkpoint1==false;
                    car1.checkpoint2==false;
                    car1.checkpoint2==false;
                }//hetzelfde voor car2
                break;
            }*/
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
