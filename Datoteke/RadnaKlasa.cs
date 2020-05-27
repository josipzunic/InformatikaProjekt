using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Datoteke
{
    public static class RadnaKlasa
    {
        public static void spremanje(List<Pitanje> listaPitanja)
        {
            try
            {
                StreamWriter sw = File.AppendText("pitanja.txt");
                foreach (Pitanje p in listaPitanja)
                {
                    string zapis = p.konstrukcijaPitanja();
                    sw.WriteLine(zapis);
                }

                sw.Close();
                MessageBox.Show("pitanje je uneseno");
            }
            catch
            {
                MessageBox.Show("Pitanje nije dobro");
            }
        }

        public static void brisanje(List<Pitanje> listaPitanja, int index)
        {
            
        }

        public static List<Pitanje> pitanja()
        {
            List<Pitanje> listaPitanja = new List<Pitanje>();
            StreamReader sr = new StreamReader("pitanja.txt");

            string pitanje;
            bool kraj = false;

            while (kraj != true)
            {
                pitanje = sr.ReadLine();
                if (pitanje == null)
                {
                    kraj = true;
                }
                else
                {
                    string[] nizStringova = pitanje.Split('|');
                    Pitanje p = new Pitanje(nizStringova[1], nizStringova[2], nizStringova[3], nizStringova[4], nizStringova[5], nizStringova[0]);
                    listaPitanja.Add(p);
                }
            }

            return listaPitanja;
        }
        
    }
}