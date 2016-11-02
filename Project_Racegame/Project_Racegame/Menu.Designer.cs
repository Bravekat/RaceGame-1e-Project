namespace Project_Racegame
{
    partial class Menu
    {
        /// <summary>
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
        {
            this.Start = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.player1left = new System.Windows.Forms.Button();
            this.player1right = new System.Windows.Forms.Button();
            this.player2left = new System.Windows.Forms.Button();
            this.player2right = new System.Windows.Forms.Button();
            this.trackleft = new System.Windows.Forms.Button();
            this.trackright = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(416, 179);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(158, 46);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(416, 407);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 46);
            this.button3.TabIndex = 1;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(416, 262);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(158, 120);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(146, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(681, 179);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(158, 120);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(681, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Player2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Track";
            // 
            // player1left
            // 
            this.player1left.Location = new System.Drawing.Point(100, 222);
            this.player1left.Name = "player1left";
            this.player1left.Size = new System.Drawing.Size(40, 37);
            this.player1left.TabIndex = 8;
            this.player1left.Text = "<";
            this.player1left.UseVisualStyleBackColor = true;
            this.player1left.Click += new System.EventHandler(this.player1left_Click);
            // 
            // player1right
            // 
            this.player1right.Location = new System.Drawing.Point(310, 222);
            this.player1right.Name = "player1right";
            this.player1right.Size = new System.Drawing.Size(40, 37);
            this.player1right.TabIndex = 9;
            this.player1right.Text = ">";
            this.player1right.UseVisualStyleBackColor = true;
            this.player1right.Click += new System.EventHandler(this.player1right_Click);
            // 
            // player2left
            // 
            this.player2left.Location = new System.Drawing.Point(635, 222);
            this.player2left.Name = "player2left";
            this.player2left.Size = new System.Drawing.Size(40, 37);
            this.player2left.TabIndex = 10;
            this.player2left.Text = "<";
            this.player2left.UseVisualStyleBackColor = true;
            // 
            // player2right
            // 
            this.player2right.Location = new System.Drawing.Point(845, 222);
            this.player2right.Name = "player2right";
            this.player2right.Size = new System.Drawing.Size(40, 37);
            this.player2right.TabIndex = 11;
            this.player2right.Text = ">";
            this.player2right.UseVisualStyleBackColor = true;
            // 
            // trackleft
            // 
            this.trackleft.Location = new System.Drawing.Point(370, 299);
            this.trackleft.Name = "trackleft";
            this.trackleft.Size = new System.Drawing.Size(40, 37);
            this.trackleft.TabIndex = 12;
            this.trackleft.Text = "<";
            this.trackleft.UseVisualStyleBackColor = true;
            // 
            // trackright
            // 
            this.trackright.Location = new System.Drawing.Point(580, 299);
            this.trackright.Name = "trackright";
            this.trackright.Size = new System.Drawing.Size(40, 37);
            this.trackright.TabIndex = 13;
            this.trackright.Text = ">";
            this.trackright.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.trackright);
            this.Controls.Add(this.trackleft);
            this.Controls.Add(this.player2right);
            this.Controls.Add(this.player2left);
            this.Controls.Add(this.player1right);
            this.Controls.Add(this.player1left);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Start);
            this.Name = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button player1left;
        private System.Windows.Forms.Button player1right;
        private System.Windows.Forms.Button player2left;
        private System.Windows.Forms.Button player2right;
        private System.Windows.Forms.Button trackleft;
        private System.Windows.Forms.Button trackright;
    }
}