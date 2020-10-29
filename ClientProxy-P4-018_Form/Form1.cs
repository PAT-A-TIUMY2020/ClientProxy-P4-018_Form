using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientProxy_P4_018_Form
{
    public partial class Form1 : Form
    {
        ServiceReference1.MatematikaClient obj = new ServiceReference1.MatematikaClient();
        ServiceReference1.Koordinat a = new ServiceReference1.Koordinat();
        ServiceReference1.Koordinat b = new ServiceReference1.Koordinat();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a + b;
            textBox9.Text = c.ToString();
        }
    }
}
