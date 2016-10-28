using Project_Racegame;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace Project_Racegame
{

    public enum Karakter { Zombie1, Zombie2 };
    public enum Map { Standard };
    public enum ColorHandler { Gras, Water, Pitstop, Check, Finish, None, Wall_Red, Wall_Green, Wall_Blue, Wall_Geel };
    public enum ColorHandler_Walls { Red, Green, Blue, Geel };

    public class Game
    {

        public List<Decoratie> Decoratie = new List<Decoratie>();

        public Bitmap colormap;
        public Bitmap checkpoints;
        public Bitmap wallmap;
        public Bitmap circuit;

        Car car1;
        Car car2;
        public Map MapLoader;
        public Form1 Scherm;
        Label FinishMessage;
        MainMenu main;
        int checkpointPoints;


        public void Spel(MainMenu main, Form1 Scherm, Car car1, Car car2, Map MapLoader, int checkpointAmount, List<Decoratie> Decoratie)
        {
            this.car1 = car1;
            this.car2 = car2;
            this.MapLoader = MapLoader;
            this.Scherm = Scherm;
            this.Decoratie = Decoratie;
            this.main = main;
            for (int i = 0; i < checkpointAmount; i++)
            {
                checkpointPoints += 255 - i * 10;
            }
            
            switch (MapLoader)
            {
                //Maps kunnen hier geladen worden.
                case Map.Standard:
                    circuit = new Bitmap(Image.FromFile(Path.Combine(Environment.CurrentDirectory, "Standard/circuit.png")));
                    colormap = new Bitmap(Image.FromFile(Path.Combine(Environment.CurrentDirectory, "Standard/colormap.png")));
                    checkpoints = new Bitmap(Image.FromFile(Path.Combine(Environment.CurrentDirectory, "Standard/checkpoints.png")), new Size(Scherm.ClientSize.Width, Scherm.ClientSize.Height));
                    wallmap = new Bitmap(Image.FromFile(Path.Combine(Environment.CurrentDirectory, "Standard/wallmap.png")), new Size(Scherm.ClientSize.Width, Scherm.ClientSize.Height));
                    break;
            }
        }
    }
}