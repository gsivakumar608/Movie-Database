﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public DataClasses1DataContext database = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenreForm gf = new GenreForm(this);
            gf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MovieForm mf = new MovieForm(this);
            mf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MovieGenreForm mgf = new MovieGenreForm(this);
            mgf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MoviePersonForm mpf = new MoviePersonForm(this);
            mpf.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PersonForm pf = new PersonForm(this);
            pf.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RoleForm rf = new RoleForm(this);
            rf.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Instructions i = new Instructions();
            i.Show();
        }
    }
}