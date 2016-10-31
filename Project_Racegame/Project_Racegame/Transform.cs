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
            double radians = (Math.PI / 180) * (rotation.angle + speedRotate);
            double cos = Math.Cos(radians) * speedMove;
            double sin = Math.Sin(radians) * speedMove;
            rotation.rotX = (float)cos * (180 / (float)Math.PI);
            rotation.rotY = (float)sin * (180 / (float)Math.PI);
            rotation.angle = rotation.angle + speedRotate;
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
  /*  public Cirkel(float circlex, float circley)
        {
        yvar circle1 = { radius: 20, x: 5, y: 5 };
         xvar circle2 = { radius: 12, x: 10, y: 5 };
        circlex = Car.car1.posx - Car.car2.posx;
        circley = Car.car1.posy - Car.car2.posy;
        double distance = Math.Sqrt(circlex * circlex + circley + circley);
        if (distance < Car1.radius + Car2.radius)
        {
            // geen idee wat yoran wilt dat er gebeurd.
        } */
}

