using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica5
{
    public partial class Form1 : Form
    {
        int n1, n2,suma,resta,multi,div,res;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(this.Numero1.Text);
            n2 = int.Parse(this.Numero2.Text);
            res = n1 + n2;
            this.resultado.Text = res.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(this.Numero1.Text);
            n2 = int.Parse(this.Numero2.Text);
            res = n1 - n2;
            this.resultado.Text = res.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(this.Numero1.Text);
            n2 = int.Parse(this.Numero2.Text);
            res = n1 * n2;
            this.resultado.Text = res.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(this.Numero1.Text);
            n2 = int.Parse(this.Numero2.Text);
            res = n1 / n2;
            this.resultado.Text = res.ToString();
        }
    }
}
