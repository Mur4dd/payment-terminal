using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FF
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        string fin = "123A456B";
        string name = "Nicat Gəncəli";
        int borc = 36;

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToUpper() == fin)
            {
                label6.Text = "Ad və soyad : " + name;
                label7.Text = "Kredit borcu : " + borc + " AZN";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.Parse(maskedTextBox2.Text.Substring(1)) <= 0)
            {
                errorProvider1.SetError(maskedTextBox2, "0 və ya 0-dan kiçik ola bilməz");
                MessageBox.Show("Daxil edilən məbləğ 0 və ya 0-dan az ola bilməz");
            }
            else
            {
                if (int.Parse(maskedTextBox2.Text.Substring(1)) >= borc)
                {
                    DateTime dateTime = DateTime.Now;
                    richTextBox1.Text = "QƏBZ\n" +
                        "TARİX : " +
                        dateTime + "\n" +
                        "ÖDƏYƏN\n" +
                        "FIN nömrəsi : " +
                        textBox1.Text.ToUpper() + "\n" +
                        "MƏBLƏĞ" + "\n" +
                        "Ödənən məbləğ : " +
                        maskedTextBox2.Text.Substring(1) + " AZN" + "\n" +
                    "Qalıq məbləğ : " +
                        (int.Parse(maskedTextBox2.Text.Substring(1)) - borc) + " AZN";
                }
                else
                {
                    DateTime dateTime = DateTime.Now;
                    richTextBox1.Text = "QƏBZ\n" +
                        "TARİX : " +
                        dateTime + "\n" +
                        "ÖDƏYƏN\n" +
                        "Abonent kodu : " +
                        textBox1.Text + "\n" +
                        "MƏBLƏĞ" + "\n" +
                        "Ödənən məbləğ : " +
                        maskedTextBox2.Text.Substring(1) + " AZN" + "\n" +
                    "Borc : " +
                        (borc - int.Parse(maskedTextBox2.Text.Substring(1))) + " AZN";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Close();
        }
    }
}
