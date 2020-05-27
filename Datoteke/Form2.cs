using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static Datoteke.RadnaKlasa;

namespace Datoteke
{
    public partial class Form2 : Form
    {
        List<Pitanje> listaPitanja = new List<Pitanje>();
        private string tocanOdgovor;
        private int brojTocnihOdgovora;
        public void kviz()
        {
            listaPitanja = pitanja();
            Random rnd = new Random();
            int random = rnd.Next(0, listaPitanja.Count);
            tocanOdgovor = listaPitanja.ElementAt(random).TocanOdgovor;

            richTextBox1.Text = listaPitanja.ElementAt(random).TekstPitanja;
            a.Text = listaPitanja.ElementAt(random).A;
            c.Text = listaPitanja.ElementAt(random).C;
            b.Text = listaPitanja.ElementAt(random).B;
            d.Text = listaPitanja.ElementAt(random).D;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            kviz();
        }

        private void a_Click(object sender, EventArgs e)
        {
            if (a.Name == tocanOdgovor)
            {
                MessageBox.Show("tocno");
                brojTocnihOdgovora++;
            }
            else
            {
                MessageBox.Show("netocno");
            }
            
            kviz();
        }

        private void c_Click(object sender, EventArgs e)
        {
            if (c.Name == tocanOdgovor)
            {
                MessageBox.Show("tocno");
                brojTocnihOdgovora++;
            }
            else
            {
                MessageBox.Show("netocno");
            }
            
            kviz();
        }

        private void b_Click(object sender, EventArgs e)
        {
            if (b.Name == tocanOdgovor)
            {
                MessageBox.Show("tocno");
                brojTocnihOdgovora++;
            }
            else
            {
                MessageBox.Show("netocno");
            }
            
            kviz();
        }

        private void d_Click(object sender, EventArgs e)
        {
            if (d.Name == tocanOdgovor)
            {
                MessageBox.Show("tocno");
                brojTocnihOdgovora++;
            }
            else
            {
                MessageBox.Show("netocno");
            }
            
            kviz();
        }
    }
}