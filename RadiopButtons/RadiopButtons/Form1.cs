using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadiopButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void rezerviraj()
        {
            if (radioButton1.Checked)
            {
                textBox1.Text = "Odabrali ste prijevoz autobusom.";
            }
            else if (radioButton2.Checked)
            {
                textBox1.Text = "Odabrali ste prijevoz avionom.";
            }
            else if (radioButton3.Checked)
            {
                textBox1.Text = "Odabrali ste vlastiti prijevoz.";
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) => rezerviraj();
    }
}
