using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Datoteke.RadnaKlasa;

namespace Datoteke
{
    public partial class Form3 : Form
    {
        private List<Pitanje> listaPitanja = new List<Pitanje>();
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a, b, c, d, tocanOdgovor, tekstPitanja;
            a = textBox1.Text;
            b = textBox2.Text;
            c = textBox3.Text;
            d = textBox4.Text;
            tocanOdgovor = comboBox1.SelectedItem.ToString();
            tekstPitanja = richTextBox1.Text;

            Pitanje P = new Pitanje(a, b, c, d, tocanOdgovor, tekstPitanja);
            listaPitanja.Add(P);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            richTextBox1.Text = "";
            
            spremanje(listaPitanja);
        }
    }
}