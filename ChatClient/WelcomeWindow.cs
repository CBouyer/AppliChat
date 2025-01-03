﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient
{
    public partial class WelcomeWindow : Form
    {
        public WelcomeWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.bouton;
            pictureBox1.Location = new Point(143, 532);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter_1;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave_1;
            // 
            // WelcomeWindow
            // 
            BackgroundImage = Properties.Resources.VIRTUE__1___1___1_;
            ClientSize = new Size(534, 739);
            Controls.Add(pictureBox1);
            Name = "WelcomeWindow";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private PictureBox pictureBox1;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.welcome = this;
            mainWindow.Show();
            this.Hide();
        }


        private void pictureBox1_MouseEnter_1(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.bouton_click;
        }

        private void pictureBox1_MouseLeave_1(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            pictureBox1.Image = Properties.Resources.bouton;
        }
    }
}
