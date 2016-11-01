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
            this.label1.Location = new System.Drawing.Point(126, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 112);
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
            // Form1
            // 
            this.BackgroundImage = global::Project_Racegame.Properties.Resources.Ztracks1;
            this.ClientSize = new System.Drawing.Size(1024, 721);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1042, 768);
            this.MinimumSize = new System.Drawing.Size(1042, 768);
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
        private ImageList imageList1;
    }
}