using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_aplikacja_okienkowa
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            decimal a = Number_first.Value;
            decimal b = Number_second.Value;

            decimal wynik = a + b;
            label_char.Text = "+";
            Text_result.Text = wynik.ToString();
        }

        private void Button_substract_Click(object sender, EventArgs e)
        {
            decimal a = Number_first.Value;
            decimal b = Number_second.Value;

            decimal wynik = a - b;
            label_char.Text = "-";
            Text_result.Text = wynik.ToString();
        }

        private void Button_multiply_Click(object sender, EventArgs e)
        {
            decimal a = Number_first.Value;
            decimal b = Number_second.Value;

            decimal wynik = a * b;
            label_char.Text = "*";
            Text_result.Text = wynik.ToString();
        }

        private void Button_divide_Click(object sender, EventArgs e)
        {
            decimal a = Number_first.Value;
            decimal b = Number_second.Value;

            if(b == 0)
            {
                MessageBox.Show("ERROR!");
            }
            else
            {
                decimal wynik = a / b;
                label_char.Text = "/";
                Text_result.Text = wynik.ToString();
            }

            
        }
    }
}
