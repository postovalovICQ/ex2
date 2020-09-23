using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exxxzamen2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtINPUT.MaxLength = 3;
            txt1.ReadOnly = true;
            txt10.ReadOnly = true;
            txt100.ReadOnly = true;
        }

        private void txtINPUT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 48 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void btnCALCULATION_Click(object sender, EventArgs e)
        {

            int INPUT = Convert.ToInt32(txtINPUT.Text);
            if (INPUT > 99)
            {
                int peremennaya1 = INPUT % 10;
                int peremennaya2 = INPUT % 100 / 10;
                int peremennaya3 = INPUT / 100;
                txt1.Text = "" + peremennaya1;
                txt10.Text = "" + peremennaya2;
                txt100.Text = "" + peremennaya3;
            }
            else
                MessageBox.Show("Введите трехзначное число!", "Ошибка");
        }
    }
}
