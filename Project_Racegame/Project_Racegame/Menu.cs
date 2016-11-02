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
    public partial class Menu : Form
    {
        
        public bool[] zombie = {false, false, false, false, false, false, false, false};
        public bool[] map = {false, false, false, false, false, false, false, false};
        public Image[] images = { Properties.Resources.stop, Properties.Resources.Zombie1Wins };
        public Image[] tracks = { Properties.Resources.Ztracks1, Properties.Resources.Ztracks2 };
        int ic = 0; // imagecounters
        int ic2 = 0;
        int ic3 = 0;        
        public Menu()
        {         
            InitializeComponent();
            pictureBox1.Image = images[ic];
            pictureBox2.Image = images[ic2];
            pictureBox3.Image = tracks[ic3];
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();            
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void player1left_Click(object sender, EventArgs e)
        {
            ic-- ;
            if (ic < 0) { ic = 7; }
            pictureBox1.Image = images[ic];
        }

        private void player1right_Click(object sender, EventArgs e)
        {            
            ic++; 
            if (ic > 7) { ic = 0; }
            pictureBox1.Image = images[ic];
        }

        private void player2left_Click(object sender, EventArgs e)
        {
            ic2--;
            if (ic2 < 0) { ic2 = 7; }
            pictureBox2.Image = images[ic2];
        }

        private void player2right_Click(object sender, EventArgs e)
        {
            ic2++;            
            pictureBox2.Image = images[ic2];
            if (ic2 > 1) { ic2 = 0; pictureBox2.Image = images[ic2]; }
        }

        private void trackleft_Click(object sender, EventArgs e)
        {
            ic3--;
            pictureBox3.Image = tracks[ic3];
        }

        private void trackright_Click(object sender, EventArgs e)
        {
            ic3++;
            pictureBox3.Image = tracks[ic3];
        }
    }
}
