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
        Bitmap colorMap;
        Car car1;
        Car car2;

        public int playerList1 = 0;
        public int playerList2 = 0;


        Bitmap[] maps = new Bitmap[4] { Properties.Resources.Ztracks1, Properties.Resources.Ztracks2, Properties.Resources.Ztracks3, Properties.Resources.Ztracks4 };
        Bitmap[] colorMaps = new Bitmap[4] { Properties.Resources.Ztracks1_colormap, Properties.Resources.Ztracks2_colormap, Properties.Resources.Ztracks3_colormap, Properties.Resources.Ztracks4_colormap };
        int[,,] positions = new int[4, 2, 2] { { { 20, 250 }, { 60, 250 } }, { { 540, 210 }, { 580, 210 } }, { { 130, 270 }, { 170, 270 } }, { { 10, 370 }, { 50, 370 } } };

        public Form1(int map, int player1, int player2)
        {
            InitializeComponent();
            BackgroundImage = maps[map];
            colorMap = colorMaps[map];
            car1 = new Car(1, positions[map, 0, 0], positions[map, 0, 1], 32, 46);
            car2 = new Car(2, positions[map, 1, 0], positions[map, 1, 1], 32, 46);
            playerList1 = player1;
            playerList2 = player2;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            if(car1.wins == true || car2.wins == true)
            {
                if (car1.wins == true)
                {
                    Image p1wins = Properties.Resources.Zombie1Wins;
                    e.Graphics.DrawImage(p1wins, 100, 300, 824, 104);
                    int i = 0;
                    while (i <= 2000000)
                    {
                        i++;
                    }
                    Application.Exit();
                }
                if (car2.wins == true)
                {
                    Image p2wins = Properties.Resources.Zombie2Wins;
                    e.Graphics.DrawImage(p2wins, 100, 300, 824, 104);
                    int i = 0;
                    while (i <= 20000)
                    {
                        i++;
                    }
                    Application.Exit();
                }
            }
            // snelheid p1
            Image voeten1 = Properties.Resources.Voetjes;
            if (car1.speed == 4)
            {
                e.Graphics.DrawImage(voeten1, 177, 520, 8, 8);
                e.Graphics.DrawImage(voeten1, 187, 520, 8, 8);
                e.Graphics.DrawImage(voeten1, 197, 520, 8, 8);
                e.Graphics.DrawImage(voeten1, 207, 520, 8, 8);
            }
            if (car1.speed == 3)
            {
                e.Graphics.DrawImage(voeten1, 177, 520, 8, 8);
                e.Graphics.DrawImage(voeten1, 187, 520, 8, 8);
                e.Graphics.DrawImage(voeten1, 197, 520, 8, 8);
            }
            if (car1.speed == 2)
            {
                e.Graphics.DrawImage(voeten1, 177, 520, 8, 8);
                e.Graphics.DrawImage(voeten1, 187, 520, 8, 8);
            }
            if (car1.speed == 1)
            {
                e.Graphics.DrawImage(voeten1, 177, 520, 8, 8);
            }
            // energie p1
            Image energie1 = Properties.Resources.Fuel;
            if (car1.energie >= 80)
            {
                e.Graphics.DrawImage(energie1, 175, 505, 12, 12);
                e.Graphics.DrawImage(energie1, 185, 505, 12, 12);
                e.Graphics.DrawImage(energie1, 195, 505, 12, 12);
                e.Graphics.DrawImage(energie1, 205, 505, 12, 12);
                e.Graphics.DrawImage(energie1, 215, 505, 12, 12);
            }
            if (car1.energie >= 60 && car1.energie <= 80)
            {
                e.Graphics.DrawImage(energie1, 175, 505, 12, 12);
                e.Graphics.DrawImage(energie1, 185, 505, 12, 12);
                e.Graphics.DrawImage(energie1, 195, 505, 12, 12);
                e.Graphics.DrawImage(energie1, 205, 505, 12, 12);
            }
            if (car1.energie >= 40 && car1.energie <= 60)
            {
                e.Graphics.DrawImage(energie1, 175, 505, 12, 12);
                e.Graphics.DrawImage(energie1, 185, 505, 12, 12);
                e.Graphics.DrawImage(energie1, 195, 505, 12, 12);
            }
            if (car1.energie >= 20 && car1.energie <= 40)
            {
                e.Graphics.DrawImage(energie1, 175, 505, 12, 12);
                e.Graphics.DrawImage(energie1, 185, 505, 12, 12);
            }
            if (car1.energie <= 20)
            {
                e.Graphics.DrawImage(energie1, 175, 505, 12, 12);
            }
            // Ronde p1
            Image ronde1 = Properties.Resources.Ronde;
            if (car1.ronde == 1)
            {
                e.Graphics.DrawImage(ronde1, 175, 530, 12, 12);
            }
            if (car1.ronde == 2)
            {
                e.Graphics.DrawImage(ronde1, 175, 530, 12, 12);
                e.Graphics.DrawImage(ronde1, 185, 530, 12, 12);
            }
            if (car1.ronde == 3)
            {
                e.Graphics.DrawImage(ronde1, 175, 530, 12, 12);
                e.Graphics.DrawImage(ronde1, 185, 530, 12, 12);
                e.Graphics.DrawImage(ronde1, 195, 530, 12, 12);
            }
            // Pitstops p1
            Image Pitstops1 = Properties.Resources.Lightning;
            if (car1.aantalpitstops == 1)
            {
                e.Graphics.DrawImage(Pitstops1, 175, 545, 12, 12);
            }
            if (car1.aantalpitstops == 2)
            {
                e.Graphics.DrawImage(Pitstops1, 175, 545, 12, 12);
                e.Graphics.DrawImage(Pitstops1, 185, 545, 12, 12);
            }
            if (car1.aantalpitstops == 3)
            {
                e.Graphics.DrawImage(Pitstops1, 175, 545, 12, 12);
                e.Graphics.DrawImage(Pitstops1, 185, 545, 12, 12);
                e.Graphics.DrawImage(Pitstops1, 195, 545, 12, 12);
            }
            if (car1.aantalpitstops == 4)
            {
                e.Graphics.DrawImage(Pitstops1, 175, 545, 12, 12);
                e.Graphics.DrawImage(Pitstops1, 185, 545, 12, 12);
                e.Graphics.DrawImage(Pitstops1, 195, 545, 12, 12);
                e.Graphics.DrawImage(Pitstops1, 205, 545, 12, 12);
            }
            if (car1.aantalpitstops == 5)
            {
                e.Graphics.DrawImage(Pitstops1, 175, 545, 12, 12);
                e.Graphics.DrawImage(Pitstops1, 185, 545, 12, 12);
                e.Graphics.DrawImage(Pitstops1, 195, 545, 12, 12);
                e.Graphics.DrawImage(Pitstops1, 205, 545, 12, 12);
                e.Graphics.DrawImage(Pitstops1, 215, 545, 12, 12);
            }
            // snelheid p2
            Image voeten2 = Properties.Resources.Voetjes;
            if (car2.speed == 4)
            {
                e.Graphics.DrawImage(voeten2, 242, 520, 8, 8);
                e.Graphics.DrawImage(voeten2, 252, 520, 8, 8);
                e.Graphics.DrawImage(voeten2, 262, 520, 8, 8);
                e.Graphics.DrawImage(voeten2, 272, 520, 8, 8);
            }
            if (car2.speed == 3)
            {
                e.Graphics.DrawImage(voeten2, 242, 520, 8, 8);
                e.Graphics.DrawImage(voeten2, 252, 520, 8, 8);
                e.Graphics.DrawImage(voeten2, 262, 520, 8, 8);
            }
            if (car2.speed == 2)
            {
                e.Graphics.DrawImage(voeten2, 242, 520, 8, 8);
                e.Graphics.DrawImage(voeten2, 252, 520, 8, 8);
            }
            if (car2.speed == 1)
            {
                e.Graphics.DrawImage(voeten2, 242, 520, 8, 8);
            }
            // energie p2
            Image energie2 = Properties.Resources.Fuel;
            if (car2.energie >= 80)
            {
                e.Graphics.DrawImage(energie2, 240, 505, 12, 12);
                e.Graphics.DrawImage(energie2, 250, 505, 12, 12);
                e.Graphics.DrawImage(energie2, 260, 505, 12, 12);
                e.Graphics.DrawImage(energie2, 270, 505, 12, 12);
                e.Graphics.DrawImage(energie2, 280, 505, 12, 12);
            }
            if (car2.energie >= 60 && car2.energie <= 80)
            {
                e.Graphics.DrawImage(energie2, 240, 505, 12, 12);
                e.Graphics.DrawImage(energie2, 250, 505, 12, 12);
                e.Graphics.DrawImage(energie2, 260, 505, 12, 12);
                e.Graphics.DrawImage(energie2, 270, 505, 12, 12);
            }
            if (car2.energie >= 40 && car2.energie <= 60)
            {
                e.Graphics.DrawImage(energie2, 240, 505, 12, 12);
                e.Graphics.DrawImage(energie2, 250, 505, 12, 12);
                e.Graphics.DrawImage(energie2, 260, 505, 12, 12);
            }
            if (car2.energie >= 20 && car2.energie <= 40)
            {
                e.Graphics.DrawImage(energie2, 240, 505, 12, 12);
                e.Graphics.DrawImage(energie2, 250, 505, 12, 12);
            }
            if (car2.energie <= 20)
            {
                e.Graphics.DrawImage(energie2, 240, 505, 12, 12);
            }
            // Ronde p2
            Image ronde2 = Properties.Resources.Ronde;
            if (car2.ronde == 1)
            {
                e.Graphics.DrawImage(ronde2, 240, 530, 12, 12);
            }
            if (car2.ronde == 2)
            {
                e.Graphics.DrawImage(ronde2, 240, 530, 12, 12);
                e.Graphics.DrawImage(ronde2, 250, 530, 12, 12);
            }
            if (car2.ronde == 3)
            {
                e.Graphics.DrawImage(ronde2, 240, 530, 12, 12);
                e.Graphics.DrawImage(ronde2, 250, 530, 12, 12);
                e.Graphics.DrawImage(ronde2, 260, 530, 12, 12);
            }
            // Pitstops p1
            Image Pitstops2 = Properties.Resources.Lightning;
            if (car2.aantalpitstops == 1)
            {
                e.Graphics.DrawImage(Pitstops1, 240, 545, 12, 12);
            }
            if (car2.aantalpitstops == 2)
            {
                e.Graphics.DrawImage(Pitstops1, 240, 545, 12, 12);
                e.Graphics.DrawImage(Pitstops1, 250, 545, 12, 12);
            }
            if (car2.aantalpitstops == 3)
            {
                e.Graphics.DrawImage(Pitstops1, 240, 545, 12, 12);
                e.Graphics.DrawImage(Pitstops1, 250, 545, 12, 12);
                e.Graphics.DrawImage(Pitstops1, 260, 545, 12, 12);
            }
            if (car2.aantalpitstops == 4)
            {
                e.Graphics.DrawImage(Pitstops1, 240, 545, 12, 12);
                e.Graphics.DrawImage(Pitstops1, 250, 545, 12, 12);
                e.Graphics.DrawImage(Pitstops1, 260, 545, 12, 12);
                e.Graphics.DrawImage(Pitstops1, 270, 545, 12, 12);
            }
            if (car2.aantalpitstops == 5)
            {
                e.Graphics.DrawImage(Pitstops1, 240, 545, 12, 12);
                e.Graphics.DrawImage(Pitstops1, 250, 545, 12, 12);
                e.Graphics.DrawImage(Pitstops1, 260, 545, 12, 12);
                e.Graphics.DrawImage(Pitstops1, 270, 545, 12, 12);
                e.Graphics.DrawImage(Pitstops1, 280, 545, 12, 12);
            }

            switch(playerList1)
            {
                case 0:
                    imageList1.Draw(e.Graphics, new Point((int)car1.carTransform.position.posX, (int)car1.carTransform.position.posY), car1.spritenumber);
                    break;
                case 1:
                    imageList2.Draw(e.Graphics, new Point((int)car1.carTransform.position.posX, (int)car1.carTransform.position.posY), car1.spritenumber);
                    break;
                case 2:
                    imageList3.Draw(e.Graphics, new Point((int)car1.carTransform.position.posX, (int)car1.carTransform.position.posY), car1.spritenumber);
                    break;
                case 3:
                    imageList4.Draw(e.Graphics, new Point((int)car1.carTransform.position.posX, (int)car1.carTransform.position.posY), car1.spritenumber);
                    break;
                case 4:
                    imageList5.Draw(e.Graphics, new Point((int)car1.carTransform.position.posX, (int)car1.carTransform.position.posY), car1.spritenumber);
                    break;
                case 5:
                    imageList6.Draw(e.Graphics, new Point((int)car1.carTransform.position.posX, (int)car1.carTransform.position.posY), car1.spritenumber);
                    break;
                case 6:
                    imageList7.Draw(e.Graphics, new Point((int)car1.carTransform.position.posX, (int)car1.carTransform.position.posY), car1.spritenumber);
                    break;
                case 7:
                    imageList8.Draw(e.Graphics, new Point((int)car1.carTransform.position.posX, (int)car1.carTransform.position.posY), car1.spritenumber);
                    break;
            }

            switch (playerList2)
            {
                case 0:
                    imageList1.Draw(e.Graphics, new Point((int)car2.carTransform.position.posX, (int)car2.carTransform.position.posY), car2.spritenumber);
                    break;
                case 1:
                    imageList2.Draw(e.Graphics, new Point((int)car2.carTransform.position.posX, (int)car2.carTransform.position.posY), car2.spritenumber);
                    break;
                case 2:
                    imageList3.Draw(e.Graphics, new Point((int)car2.carTransform.position.posX, (int)car2.carTransform.position.posY), car2.spritenumber);
                    break;
                case 3:
                    imageList4.Draw(e.Graphics, new Point((int)car2.carTransform.position.posX, (int)car2.carTransform.position.posY), car2.spritenumber);
                    break;
                case 4:
                    imageList5.Draw(e.Graphics, new Point((int)car2.carTransform.position.posX, (int)car2.carTransform.position.posY), car2.spritenumber);
                    break;
                case 5:
                    imageList6.Draw(e.Graphics, new Point((int)car2.carTransform.position.posX, (int)car2.carTransform.position.posY), car2.spritenumber);
                    break;
                case 6:
                    imageList7.Draw(e.Graphics, new Point((int)car2.carTransform.position.posX, (int)car2.carTransform.position.posY), car2.spritenumber);
                    break;
                case 7:
                    imageList8.Draw(e.Graphics, new Point((int)car2.carTransform.position.posX, (int)car2.carTransform.position.posY), car2.spritenumber);
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            car1.ColorCollision(colorMap, label3, label5, label7);
            car2.ColorCollision(colorMap, label4, label6, label8);

            car1.spritenumber = car1.FrameSelection(car1.spritenumber);
            car2.spritenumber = car2.FrameSelection(car2.spritenumber);

            this.label1.Text = "ENERGIE p1: " + Math.Round(car1.energie) + "%";
            this.label2.Text = "ENERGIE p2: " + Math.Round(car2.energie) + "%";

            if (car1.down == false && car1.up == false)
            {
                car1.snelheid = 0;
            }
            if (car2.down == false && car2.up == false)
            {
                car2.snelheid = 0;
            }

            if (car1.up == true)
            {
                car1.carTransform.Move(car1.movespeedforward);
                car1.snelheid = car1.movespeedforward;
                if (car1.right == true)
                {
                    car1.carTransform.Move(car1.movespeedup, car1.rotatespeed);
                }
                if (car1.left == true)
                {
                    car1.carTransform.Move(car1.movespeedup, -car1.rotatespeed);
                }
            }
            if (car1.down == true)
            {
                car1.carTransform.Move(-car1.movespeedbackward);
                car1.snelheid = car1.movespeedbackward;
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
                car2.snelheid = car2.movespeedforward;
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
                car2.snelheid = car2.movespeedbackward;
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

            double circlex = car1.carTransform.position.posX - car2.carTransform.position.posX;
            double circley = car1.carTransform.position.posY - car2.carTransform.position.posY;
            double distance = Math.Sqrt(Math.Pow(circlex, 2) + Math.Pow(circley, 2));
            if (distance < 20)
            {
                car1.carTransform.position.posX += (car1.carTransform.position.posX - car2.carTransform.position.posX) * (Math.Abs(car2.movespeedup) / 9 + 0.4f) / 4;
                car1.carTransform.position.posY += (car1.carTransform.position.posY - car2.carTransform.position.posY) * (Math.Abs(car2.movespeedup) / 9 + 0.4f) / 4;
                car2.carTransform.position.posX += (car2.carTransform.position.posX - car1.carTransform.position.posX) * (Math.Abs(car1.movespeedup) / 9 + 0.4f) / 4;
                car2.carTransform.position.posY += (car2.carTransform.position.posY - car1.carTransform.position.posY) * (Math.Abs(car1.movespeedup) / 9 + 0.4f) / 4;

            }
            
            if (car1.ronde == 1 || car2.ronde == 3)
            {
                if (car1.ronde == 1)
                {
                    car1.wins = true;//player1 wins
                }
                if (car2.ronde == 3)
                {
                    car2.wins = true;//player2 wins
                }
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
