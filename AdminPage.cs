﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Read_feed_back f1 = new Read_feed_back();
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.username = null;
            Program.nameingame= null;
            this.Hide();
            HomePage f1 = new HomePage();
            f1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Block b = new Block();
            this.Hide();
            b.Show();
        }
    }
}
