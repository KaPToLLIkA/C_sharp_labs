using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C = LAB5_SERVICE_UI.NumConv;

namespace LAB5_SERVICE_UI
{
    public partial class Form1 : Form
    {
        private C.NumberConversionSoapTypeClient client = new C.NumberConversionSoapTypeClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void keyPressValidator(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void buttonConvToWords_Click(object sender, EventArgs e)
        {
            this.textBoxResWords.Text = client.NumberToWords(Convert.ToUInt64(this.textBoxInNum1.Text == "" ? "0" : this.textBoxInNum1.Text));
        }

        private void buttonConvToDollars_Click(object sender, EventArgs e)
        {
            this.textBoxResDollars.Text = client.NumberToDollars(Convert.ToUInt64(this.textBoxInNum2.Text == "" ? "0" : this.textBoxInNum2.Text));
        }
    }
}
