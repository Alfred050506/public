using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("пошел домой");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("пошел на учёбу");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("пошел работать");
        }
    }
}
