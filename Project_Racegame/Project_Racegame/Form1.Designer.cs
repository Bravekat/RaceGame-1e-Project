using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Project_Racegame
{
    partial class Form1
    {
        /// <summary>
        /// test
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.imageList4 = new System.Windows.Forms.ImageList(this.components);
            this.imageList5 = new System.Windows.Forms.ImageList(this.components);
            this.imageList6 = new System.Windows.Forms.ImageList(this.components);
            this.imageList7 = new System.Windows.Forms.ImageList(this.components);
            this.imageList8 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Zombie animation 1-1.png");
            this.imageList1.Images.SetKeyName(1, "Zombie animation 1-2.png");
            this.imageList1.Images.SetKeyName(2, "Zombie animation 1-3.png");
            this.imageList1.Images.SetKeyName(3, "Zombie animation 1-4.png");
            this.imageList1.Images.SetKeyName(4, "Zombie animation 1-5.png");
            this.imageList1.Images.SetKeyName(5, "Zombie animation 1-6.png");
            this.imageList1.Images.SetKeyName(6, "Zombie animation 1-7.png");
            this.imageList1.Images.SetKeyName(7, "Zombie animation 1-8.png");
            this.imageList1.Images.SetKeyName(8, "Zombie animation 1-9.png");
            this.imageList1.Images.SetKeyName(9, "Zombie animation 1-10.png");
            this.imageList1.Images.SetKeyName(10, "Zombie animation 1-11.png");
            this.imageList1.Images.SetKeyName(11, "Zombie animation 1-12.png");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 551);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(539, 551);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 518);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(539, 518);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 584);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(539, 584);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "label8";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Zombie animation 2-1.png");
            this.imageList2.Images.SetKeyName(1, "Zombie animation 2-2.png");
            this.imageList2.Images.SetKeyName(2, "Zombie animation 2-3.png");
            this.imageList2.Images.SetKeyName(3, "Zombie animation 2-4.png");
            this.imageList2.Images.SetKeyName(4, "Zombie animation 2-5.png");
            this.imageList2.Images.SetKeyName(5, "Zombie animation 2-6.png");
            this.imageList2.Images.SetKeyName(6, "Zombie animation 2-7.png");
            this.imageList2.Images.SetKeyName(7, "Zombie animation 2-8.png");
            this.imageList2.Images.SetKeyName(8, "Zombie animation 2-9.png");
            this.imageList2.Images.SetKeyName(9, "Zombie animation 2-10.png");
            this.imageList2.Images.SetKeyName(10, "Zombie animation 2-11.png");
            this.imageList2.Images.SetKeyName(11, "Zombie animation 2-12.png");
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "Zombie animation 3-1.png");
            this.imageList3.Images.SetKeyName(1, "Zombie animation 3-2.png");
            this.imageList3.Images.SetKeyName(2, "Zombie animation 3-3.png");
            this.imageList3.Images.SetKeyName(3, "Zombie animation 3-4.png");
            this.imageList3.Images.SetKeyName(4, "Zombie animation 3-5.png");
            this.imageList3.Images.SetKeyName(5, "Zombie animation 3-6.png");
            this.imageList3.Images.SetKeyName(6, "Zombie animation 3-7.png");
            this.imageList3.Images.SetKeyName(7, "Zombie animation 3-8.png");
            this.imageList3.Images.SetKeyName(8, "Zombie animation 3-9.png");
            this.imageList3.Images.SetKeyName(9, "Zombie animation 3-10.png");
            this.imageList3.Images.SetKeyName(10, "Zombie animation 3-11.png");
            this.imageList3.Images.SetKeyName(11, "Zombie animation 3-12.png");
            // 
            // imageList4
            // 
            this.imageList4.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList4.ImageStream")));
            this.imageList4.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList4.Images.SetKeyName(0, "Zombie animation 4-1.png");
            this.imageList4.Images.SetKeyName(1, "Zombie animation 4-2.png");
            this.imageList4.Images.SetKeyName(2, "Zombie animation 4-3.png");
            this.imageList4.Images.SetKeyName(3, "Zombie animation 4-4.png");
            this.imageList4.Images.SetKeyName(4, "Zombie animation 4-5.png");
            this.imageList4.Images.SetKeyName(5, "Zombie animation 4-6.png");
            this.imageList4.Images.SetKeyName(6, "Zombie animation 4-7.png");
            this.imageList4.Images.SetKeyName(7, "Zombie animation 4-8.png");
            this.imageList4.Images.SetKeyName(8, "Zombie animation 4-9.png");
            this.imageList4.Images.SetKeyName(9, "Zombie animation 4-10.png");
            this.imageList4.Images.SetKeyName(10, "Zombie animation 4-11.png");
            this.imageList4.Images.SetKeyName(11, "Zombie animation 4-12.png");
            // 
            // imageList5
            // 
            this.imageList5.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList5.ImageStream")));
            this.imageList5.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList5.Images.SetKeyName(0, "Zombie animation 5-1.png");
            this.imageList5.Images.SetKeyName(1, "Zombie animation 5-2.png");
            this.imageList5.Images.SetKeyName(2, "Zombie animation 5-3.png");
            this.imageList5.Images.SetKeyName(3, "Zombie animation 5-4.png");
            this.imageList5.Images.SetKeyName(4, "Zombie animation 5-5.png");
            this.imageList5.Images.SetKeyName(5, "Zombie animation 5-6.png");
            this.imageList5.Images.SetKeyName(6, "Zombie animation 5-7.png");
            this.imageList5.Images.SetKeyName(7, "Zombie animation 5-8.png");
            this.imageList5.Images.SetKeyName(8, "Zombie animation 5-9.png");
            this.imageList5.Images.SetKeyName(9, "Zombie animation 5-10.png");
            this.imageList5.Images.SetKeyName(10, "Zombie animation 5-11.png");
            this.imageList5.Images.SetKeyName(11, "Zombie animation 5-12.png");
            // 
            // imageList6
            // 
            this.imageList6.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList6.ImageStream")));
            this.imageList6.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList6.Images.SetKeyName(0, "Zombie animation 6-1.png");
            this.imageList6.Images.SetKeyName(1, "Zombie animation 6-2.png");
            this.imageList6.Images.SetKeyName(2, "Zombie animation 6-3.png");
            this.imageList6.Images.SetKeyName(3, "Zombie animation 6-4.png");
            this.imageList6.Images.SetKeyName(4, "Zombie animation 6-5.png");
            this.imageList6.Images.SetKeyName(5, "Zombie animation 6-6.png");
            this.imageList6.Images.SetKeyName(6, "Zombie animation 6-7.png");
            this.imageList6.Images.SetKeyName(7, "Zombie animation 6-8.png");
            this.imageList6.Images.SetKeyName(8, "Zombie animation 6-9.png");
            this.imageList6.Images.SetKeyName(9, "Zombie animation 6-10.png");
            this.imageList6.Images.SetKeyName(10, "Zombie animation 6-11.png");
            this.imageList6.Images.SetKeyName(11, "Zombie animation 6-12.png");
            // 
            // imageList7
            // 
            this.imageList7.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList7.ImageStream")));
            this.imageList7.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList7.Images.SetKeyName(0, "Zombie animation 7-1.png");
            this.imageList7.Images.SetKeyName(1, "Zombie animation 7-2.png");
            this.imageList7.Images.SetKeyName(2, "Zombie animation 7-3.png");
            this.imageList7.Images.SetKeyName(3, "Zombie animation 7-4.png");
            this.imageList7.Images.SetKeyName(4, "Zombie animation 7-5.png");
            this.imageList7.Images.SetKeyName(5, "Zombie animation 7-6.png");
            this.imageList7.Images.SetKeyName(6, "Zombie animation 7-7.png");
            this.imageList7.Images.SetKeyName(7, "Zombie animation 7-8.png");
            this.imageList7.Images.SetKeyName(8, "Zombie animation 7-9.png");
            this.imageList7.Images.SetKeyName(9, "Zombie animation 7-10.png");
            this.imageList7.Images.SetKeyName(10, "Zombie animation 7-11.png");
            this.imageList7.Images.SetKeyName(11, "Zombie animation 7-12.png");
            // 
            // imageList8
            // 
            this.imageList8.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList8.ImageStream")));
            this.imageList8.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList8.Images.SetKeyName(0, "Zombie animation 8-1.png");
            this.imageList8.Images.SetKeyName(1, "Zombie animation 8-2.png");
            this.imageList8.Images.SetKeyName(2, "Zombie animation 8-3.png");
            this.imageList8.Images.SetKeyName(3, "Zombie animation 8-4.png");
            this.imageList8.Images.SetKeyName(4, "Zombie animation 8-5.png");
            this.imageList8.Images.SetKeyName(5, "Zombie animation 8-6.png");
            this.imageList8.Images.SetKeyName(6, "Zombie animation 8-7.png");
            this.imageList8.Images.SetKeyName(7, "Zombie animation 8-8.png");
            this.imageList8.Images.SetKeyName(8, "Zombie animation 8-9.png");
            this.imageList8.Images.SetKeyName(9, "Zombie animation 8-10.png");
            this.imageList8.Images.SetKeyName(10, "Zombie animation 8-11.png");
            this.imageList8.Images.SetKeyName(11, "Zombie animation 8-12.png");
            // 
            // Form1
            // 

            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);

            /*this.BackgroundImage = Image.FromFile(Path.Combine(Environment.CurrentDirectory, "Ztracks1.png")); */
            this.ClientSize = new System.Drawing.Size(1042, 768);
            this.MaximumSize = new System.Drawing.Size(1042, 768);

            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Form1";
            this.Text = "Racegame";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private ImageList imageList1;
        private ImageList imageList2;
        private ImageList imageList3;
        private ImageList imageList4;
        private ImageList imageList5;
        private ImageList imageList6;
        private ImageList imageList7;
        private ImageList imageList8;
    }
}