using System;
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
            double radians = (Math.PI / 180) * (rotation.Angle + speedRotate);
            double cos = Math.Cos(radians) * speedMove;
            double sin = Math.Sin(radians) * speedMove;
            rotation.rotX = (float)cos * (180 / (float)Math.PI);
            rotation.rotY = (float)sin * (180 / (float)Math.PI);
            rotation.Angle = rotation.Angle + speedRotate;
            position.posX += rotation.rotX;
            position.posY += rotation.rotY;

        }
    }

    public class Rotation
    {
        private float angle;
        public float Angle
        {
            get
            {
                return angle;
            }
            set
            {
                if (value > 360)
                    angle = value - 360;
                if (value < 1)
                    angle = value + 360;
            }
        }
        public float rotX;
        public float rotY;

        public Rotation()
        {
            Angle = 360;
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
