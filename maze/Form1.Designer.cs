namespace maze
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mazearea = new System.Windows.Forms.Panel();
            this.goal = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.mazearea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(700, 23);
            this.label1.TabIndex = 0;
            this.label1.Tag = "wall";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(758, 23);
            this.label2.TabIndex = 1;
            this.label2.Tag = "wall";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(677, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 341);
            this.label3.TabIndex = 2;
            this.label3.Tag = "wall";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(115, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 129);
            this.label4.TabIndex = 3;
            this.label4.Tag = "wall";
            // 
            // mazearea
            // 
            this.mazearea.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mazearea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mazearea.Controls.Add(this.label32);
            this.mazearea.Controls.Add(this.goal);
            this.mazearea.Controls.Add(this.player);
            this.mazearea.Controls.Add(this.label31);
            this.mazearea.Controls.Add(this.label30);
            this.mazearea.Controls.Add(this.label29);
            this.mazearea.Controls.Add(this.label28);
            this.mazearea.Controls.Add(this.label27);
            this.mazearea.Controls.Add(this.label26);
            this.mazearea.Controls.Add(this.label25);
            this.mazearea.Controls.Add(this.label24);
            this.mazearea.Controls.Add(this.label23);
            this.mazearea.Controls.Add(this.label22);
            this.mazearea.Controls.Add(this.label21);
            this.mazearea.Controls.Add(this.label20);
            this.mazearea.Controls.Add(this.label19);
            this.mazearea.Controls.Add(this.label18);
            this.mazearea.Controls.Add(this.label17);
            this.mazearea.Controls.Add(this.label16);
            this.mazearea.Controls.Add(this.label15);
            this.mazearea.Controls.Add(this.label14);
            this.mazearea.Controls.Add(this.label13);
            this.mazearea.Controls.Add(this.label12);
            this.mazearea.Controls.Add(this.label11);
            this.mazearea.Controls.Add(this.label10);
            this.mazearea.Controls.Add(this.label9);
            this.mazearea.Controls.Add(this.label8);
            this.mazearea.Controls.Add(this.label7);
            this.mazearea.Controls.Add(this.label6);
            this.mazearea.Controls.Add(this.label5);
            this.mazearea.Controls.Add(this.label4);
            this.mazearea.Controls.Add(this.label3);
            this.mazearea.Controls.Add(this.label2);
            this.mazearea.Controls.Add(this.label1);
            this.mazearea.Location = new System.Drawing.Point(12, 12);
            this.mazearea.Name = "mazearea";
            this.mazearea.Size = new System.Drawing.Size(776, 426);
            this.mazearea.TabIndex = 0;
            this.mazearea.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // goal
            // 
            this.goal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.goal.Location = new System.Drawing.Point(680, 374);
            this.goal.Name = "goal";
            this.goal.Size = new System.Drawing.Size(81, 32);
            this.goal.TabIndex = 32;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.player.Location = new System.Drawing.Point(117, 179);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(21, 21);
            this.player.TabIndex = 31;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(677, 353);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(84, 21);
            this.label31.TabIndex = 30;
            this.label31.Tag = "wall";
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(114, 152);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(166, 23);
            this.label30.TabIndex = 29;
            this.label30.Tag = "wall";
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(466, 353);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(23, 53);
            this.label29.TabIndex = 28;
            this.label29.Tag = "wall";
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(339, 353);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(84, 21);
            this.label28.TabIndex = 27;
            this.label28.Tag = "wall";
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(263, 302);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(84, 21);
            this.label27.TabIndex = 26;
            this.label27.Tag = "wall";
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(257, 302);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(23, 104);
            this.label26.TabIndex = 25;
            this.label26.Tag = "wall";
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(185, 254);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(23, 110);
            this.label25.TabIndex = 24;
            this.label25.Tag = "wall";
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(188, 254);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(225, 21);
            this.label24.TabIndex = 23;
            this.label24.Tag = "wall";
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(400, 212);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(23, 152);
            this.label23.TabIndex = 22;
            this.label23.Tag = "wall";
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(408, 302);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(128, 21);
            this.label22.TabIndex = 21;
            this.label22.Tag = "wall";
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(600, 267);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(23, 139);
            this.label21.TabIndex = 20;
            this.label21.Tag = "wall";
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(530, 212);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(158, 21);
            this.label20.TabIndex = 19;
            this.label20.Tag = "wall";
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(530, 212);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 152);
            this.label19.TabIndex = 18;
            this.label19.Tag = "wall";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(466, 164);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 104);
            this.label18.TabIndex = 17;
            this.label18.Tag = "wall";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(339, 164);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(279, 21);
            this.label17.TabIndex = 16;
            this.label17.Tag = "wall";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(600, 115);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 21);
            this.label16.TabIndex = 15;
            this.label16.Tag = "wall";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(530, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 21);
            this.label15.TabIndex = 14;
            this.label15.Tag = "wall";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(530, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 104);
            this.label14.TabIndex = 13;
            this.label14.Tag = "wall";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(405, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 21);
            this.label13.TabIndex = 12;
            this.label13.Tag = "wall";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(466, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 104);
            this.label12.TabIndex = 11;
            this.label12.Tag = "wall";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(324, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 22);
            this.label11.TabIndex = 10;
            this.label11.Tag = "wall";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(116, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(214, 23);
            this.label10.TabIndex = 9;
            this.label10.Tag = "wall";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(324, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 155);
            this.label9.TabIndex = 8;
            this.label9.Tag = "wall";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(204, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 23);
            this.label8.TabIndex = 7;
            this.label8.Tag = "wall";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(185, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 56);
            this.label7.TabIndex = 6;
            this.label7.Tag = "wall";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(257, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 56);
            this.label6.TabIndex = 5;
            this.label6.Tag = "wall";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(115, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 180);
            this.label5.TabIndex = 4;
            this.label5.Tag = "wall";
            // 
            // label32
            // 
            this.label32.BackColor = System.Drawing.Color.Black;
            this.label32.Location = new System.Drawing.Point(-3, 20);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(23, 409);
            this.label32.TabIndex = 33;
            this.label32.Tag = "wall";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mazearea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.mazearea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel mazearea;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label goal;
        private System.Windows.Forms.Label label32;
    }
}

