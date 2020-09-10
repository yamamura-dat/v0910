﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0910
{
    public partial class Form1 : Form
    {
        static Random rand = new Random();
        int[] vx = new int[11];
        int[] vy = new int[11];
        Label[] labels = new Label[11];
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 11; i++)
            {
                vx[i] = rand.Next(-15, 16);
                vy[i] = rand.Next(-15, 16);
                labels[i] = new Label();
                labels[i].AutoSize = true;
                labels[i].Text = "☆";
                Controls.Add(labels[i]);
                labels[i].Left = rand.Next(ClientSize.Width - labels[i].Width);
                labels[i].Top = rand.Next(ClientSize.Height - labels[i].Height);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
