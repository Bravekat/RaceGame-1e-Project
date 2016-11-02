using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Racegame
{
    public class Transform
    {        
        public Position position = new Position();
        public Rotation rotation = new Rotation();
        public Size size;

        public Transform(float posX, float posY, Bitmap image)
        {
            position.posX = posX;
            position.posY = posY;
            size = new Size(image);
        }

        public Transform(float posX, float posY, Point imageSize)
        {
            position.posX = posX;
            position.posY = posY;
            size = new Size(imageSize.X, imageSize.Y);
        }

        public Transform(float posX, float posY, float rotX, float rotY, Bitmap image)
        {
            position.posX = posX;
            position.posY = posY;
            rotation.rotX = rotX;
            rotation.rotY = rotY;
            size = new Size(image);
        }

        public Transform(float posX, float posY, float rotX, float rotY, Point imageSize)
        {
            position.posX = posX;
            position.posY = posY;
            rotation.rotX = rotX;
            rotation.rotY = rotY;
            size = new Size(imageSize.X, imageSize.Y);
        }

        public void Move(float speedMove)
        {
            Move(speedMove, 0);
        }

        public void Move(float speedMove, float speedRotate)
        {
            rotation.angle = rotation.angle + speedRotate;
            if (rotation.angle > 360)
                rotation.angle -= 360;
            if (rotation.angle < 1)
                rotation.angle += 360;

            double radians = (Math.PI / 180) * (rotation.angle);
            double cos = Math.Cos(radians) * speedMove;
            double sin = Math.Sin(radians) * speedMove;
            rotation.rotX = (float)cos * (180 / (float)Math.PI);
            rotation.rotY = (float)sin * (180 / (float)Math.PI);
            position.posX += rotation.rotX;
            position.posY += rotation.rotY;
        }
    }

    public class Rotation
    {
        public float angle;
        public float rotX;
        public float rotY;

        public Rotation()
        {
            angle = 270;
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

    public class Size
    {
        public float height;
        public float width;

        public Size(Bitmap image)
        {
            height = image.Height;
            width = image.Width;
        }

        public Size(float newHeight, float newWidth)
        {
            height = newHeight;
            width = newWidth;
        }
    }
}

