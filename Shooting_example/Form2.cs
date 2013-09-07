﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LSD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Scores_RW.existance();
            this.CenterToScreen();
            textBox2.KeyPress += new KeyPressEventHandler(textBox2_KeyPress);
            textBox2.KeyDown += new KeyEventHandler(keypress);
            this.KeyDown += new KeyEventHandler(keypress);
            panel1.KeyDown += new KeyEventHandler(keypress); 
        }
        private void keypress(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && textBox2.Text != "")
            {
                    Form1 f1 = new Form1();
                    f1.name = textBox2.Text;
                    f1.Show();
                    this.Hide();
                    e.Handled = true;
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.ForeColor = Program.rand_colour();
            label2.ForeColor = Program.rand_colour();
            lsd_L.ForeColor = Program.rand_colour();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit LSD?", MessageBoxButtons.YesNo) == DialogResult.Yes) { Application.Exit(); } 
        }
    }
}
