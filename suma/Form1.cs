using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace suma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //crear elobjeto y pasar valores al contructor 
            Suma sum = new Suma (double.Parse(txt1.Text), double.Parse(txt2.Text));
            //pasar valores 
            txtResult.Text = sum.rsuma().ToString();

        }
    }
}
