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
        Position pos1 = new Position(250, 250);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Red, pos1.posX, pos1.posY, 10, 10);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }

    /*public class Direction
    {
        public float dirX;
        public float dirY;
        public float rot;

        public Direction(float newRot)
        {
            Update(newRot);
        }

        public Direction(float Xdir, float Ydir)
        {
            Update(Xdir, Ydir);
        }

        public void Update(float newRot)
        {
            rot = newRot;
            double radians = (Math.PI / 180) * newRot;
            double cos = Math.Cos(radians);
            double sin = Math.Sin(radians);
            dirX = (float)cos * (180 / (float)Math.PI);
            dirY = (float)sin * (180 / (float)Math.PI);
        }

        public void Update(float Xdir, float Ydir)
        {
            dirX = Xdir;
            dirY = Ydir;
            double radians = Math.Tanh(dirY / dirX);
            rot = (float)radians*(180 / (float)Math.PI);
        }
    }*/

    public class Transform
    {
        public Position position = new Position();
        public Rotation rotation = new Rotation();

        public Transform(float posX, float posY)
        {
            position.posX = posX;
            position.posY = posY;
        }

        public Transform(float posX, float posY, float rotX, float rotY)
        {
            position.posX = posX;
            position.posY = posY;
            rotation.rotX = rotX;
            rotation.rotY = rotY;
        }

        public void Move(float speedMove)
        {
            Move(speedMove, 0);
        }

        public void Move(float speedMove, float speedRotate)
        {
            double radians = (Math.PI / 180) * (rotation.angle + speedRotate);
            double cos = Math.Cos(radians) * speedMove;
            double sin = Math.Sin(radians) * speedMove;
            rotation.rotX = (float)cos * (180 / (float)Math.PI);
            rotation.rotY = (float)sin * (180 / (float)Math.PI);
            rotation.angle = rotation.angle + speedRotate;
        }
    }

    public class Rotation
    {
        public float angle
        {
            get
            {
                return this.angle;
            }
            set
            {
                if (value > 360)
                    this.angle = value - 360;
                if (value < 1)
                    this.angle = value + 360;
            }
        }
        public float rotX;
        public float rotY;

        public Rotation()
        {
            angle = 360;
            rotX = 0;
            rotY = 0;
        }

        public Rotation(float xRot, float yRot)
        {
            rotX = xRot;
            rotY = yRot;
        }
    }

    public class Position
    {
        public float posX;
        public float posY;

        public Position()
        {
            posX = 0;
            posY = 0;
        }

        public Position(float xPos, float yPos)
        {
            posX = xPos;
            posY = yPos;
        }
    }
}
