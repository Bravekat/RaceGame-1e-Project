using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Racegame
{
    public enum DecoratieType {BoxingPlant, CannonPlant, DancingPlant, DragonPlant, Peper, SeedPlant, StarPlant};

    public class Decoratie
    {
        //dit is animatie voor een track.
        public int X;
        public int Y;
        private int Width;
        private int Height;
        private int Yteller = 0;
        private int Xteller = 0;
        private Image image1, image2;
        private DecoratieType type;
        private bool one = true;
        private bool vergroot = false;
        private bool Xvergroot = false;
        private bool Yvergroot = false;
        private bool Init = true;
        private Random Generator;
        private Timer timer;

        public Decoratie(DecoratieType type, int X, int Y)
        {
            this.type = type;
            this.X = X;
            this.Y = Y;
            Width = 32;
            Height = 32;
            Generator = new Random();
            timer = new Timer();

            timer.Enabled = true;
            timer.Interval = Generator.Next(10, 25);
            timer.Tick += new EventHandler(Loop);

            switch(type)
            {
                case DecoratieType.BoxingPlant:
                    image1 = Image.FromFile(Path.Combine(Environment.CurrentDirectory, "Decoratie/BoxingPlant1.png"));
                    image2 = Image.FromFile(Path.Combine(Environment.CurrentDirectory, "Decoratie/BoxingPlant2.png"));
                    break;

                case DecoratieType.CannonPlant:
                    image1 = Image.FromFile(Path.Combine(Environment.CurrentDirectory, "Decoratie/CannonPlant1.png"));
                    image2 = Image.FromFile(Path.Combine(Environment.CurrentDirectory, "Decoratie/CannonPlant2.png"));
                    break;

                case DecoratieType.DancingPlant:
                    image1 = Image.FromFile(Path.Combine(Environment.CurrentDirectory, "Decoratie/DancingPlant1.png"));
                    image2 = Image.FromFile(Path.Combine(Environment.CurrentDirectory, "Decoratie/DancingPlant1.png"));
                    break;

                case DecoratieType.DragonPlant:
                    image1 = Image.FromFile(Path.Combine(Environment.CurrentDirectory, "Decoratie/DragonPlant1.png"));
                    image2 = Image.FromFile(Path.Combine(Environment.CurrentDirectory, "Decoratie/DragonPlant2.png"));
                    break;

                case DecoratieType.Peper:
                    image1 = Image.FromFile(Path.Combine(Environment.CurrentDirectory, "Decoratie/Peper1.png"));
                    image2 = Image.FromFile(Path.Combine(Environment.CurrentDirectory, "Decoratie/Peper2.png"));
                    break;

                case DecoratieType.StarPlant:
                    image1 = Image.FromFile(Path.Combine(Environment.CurrentDirectory, "Decoratie/StarPlant1.png"));
                    image2 = Image.FromFile(Path.Combine(Environment.CurrentDirectory, "Decoratie/StarPlant2.png"));
                    break;

                case DecoratieType.SeedPlant:
                    image1 = Image.FromFile(Path.Combine(Environment.CurrentDirectory, "Decoratie/SeedPlant.png"));
                    break;
            }
        }
        public async void Loop(object sender, EventArgs args)
        {
            if (Init)
            {
                await Task.Delay(Generator.Next(1000, 5800));
                Init = false;
            }
            switch(type)
            {
                case DecoratieType.BoxingPlant:
                    timer.Interval = 40;
                    BoxingPlant();
                    break;

                case DecoratieType.CannonPlant:
                    timer.Interval = 30;
                    CannonPlant();
                    break;

                case DecoratieType.DancingPlant:
                    timer.Interval = 60;
                    DancingPlant();
                    break;

                case DecoratieType.DragonPlant:
                    timer.Interval = 25;
                    DragonPlant();
                    break;

                case DecoratieType.Peper:
                    timer.Interval = 35;
                    Peper();
                    break;

                case DecoratieType.StarPlant:
                    timer.Interval = 30;
                    StarPlant();
                    break;

                case DecoratieType.SeedPlant:
                    timer.Interval = 10;
                    SeedPlant();
                    break;

            }
        }

        public void Draw(Graphics G)
        {
            if (one) G.DrawImage(image1, new Rectangle(X + Xteller, Y + Yteller, Width, Height));
            if (!one) G.DrawImage(image2, new Rectangle(X + Xteller, Y + Yteller, Width, Height));
        }

        private void BoxingPlant()
        {
            if (vergroot) Xteller -= 2;
            if (!vergroot) Xteller += 2;
            ChangeSize();
        }

        private void CannonPlant()
        {
            if (vergroot) Xteller -= 1;
            if (!vergroot) Xteller += 1;
            ChangeSize();
        }

        private void DancingPlant()
        {
            if (Xteller > 20)
            {
                Xvergroot = false;
                one = !one;
            }
            if (Xteller < -20)
            {
                Xvergroot = true;
                one = !one;
            }
            if (Xvergroot)
            {
                Xteller += 1;
            }
            else
            {
                Xteller -= 1;
            }
            if (Yteller > 5) Yvergroot = false;
            if (Yteller < -5) Yvergroot = true;
            if (Yvergroot)
            {
                Yteller += 2;
            }
            else
            {
                Yteller -= 2;
            }
        }

        private void DragonPlant()
        {
            one = !one;
            if (vergroot) Yteller -= 2;
            if (!vergroot) Yteller += 2;
            ChangeSize();
        }

        private void StarPlant()
        {
            one = !one;
        }



        private void Peper()
        {
            one = !one;
            ChangeSize();
        }

        private void SeedPlant()
        {
            one = !one;
        }

        private void ChangeSize()
        {
            if (Width <= 0)
            {
                vergroot = true;
                timer.Interval = 1800;
            }
            if (Width >= 32)
            {
                vergroot = false;
                timer.Interval = 400;
            }
            if(vergroot)
            {
                Width += 2;
                Height += 2;
                X -= 1;
                Y -= 1;
            }
            else
            {
                Width -= 2;
                Height -= 2;
                X += 1;
                Y += 1;
            }
        }
    }
}
