﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace test2._2
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
           
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            List<int> c = new List<int>();
            List<int> v = new List<int>();
            List<int> b = new List<int>();

            for (int j = 0; j < 10; j++)
            {
                c.Add(rnd.Next(-10, 15));
                if (c[j] < 0 && c[j] > -10)
                {
                    v.Add(c[j]);
                }
                else if (c[j] > 0 && c[j] >= 10)
                {
                    b.Add(c[j]);
                }

            }
            c.Sort();
            listBox1.DataSource = c;
            listBox2.DataSource = v;
            listBox3.DataSource = b;
            String a = string.Join(",", c) +"\n "+ string.Join(",", b) +"\n "+ string.Join(",",v); 
            StreamWriter s = new StreamWriter(@"Rezultat.txt");
                s.Write(a);
                s.Close();
            MessageBox.Show("Saved!");
            
        }

    }
}
