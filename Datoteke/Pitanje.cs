using System.Runtime.InteropServices;

namespace Datoteke
{
    public class Pitanje
    {
        private string _a, _b, _c, _d, _tocanOdgovor, _tekstPitanja;
        public Pitanje(string a, string b, string c, string d, string tocanOdgovor, string tekstPitanja)
        {
            _a = a;
            _b = b;
            _c = c;
            _d = d;
            _tocanOdgovor = tocanOdgovor;
            _tekstPitanja = tekstPitanja;
        }

        public string A
        {
            get => _a;
            set => _a = value;
        }

        public string B
        {
            get => _b;
            set => _b = value;
        }

        public string C
        {
            get => _c;
            set => _c = value;
        }

        public string D
        {
            get => _d;
            set => _d = value;
        }

        public string TocanOdgovor
        {
            get => _tocanOdgovor;
            set => _tocanOdgovor = value;
        }

        public string TekstPitanja
        {
            get => _tekstPitanja;
            set => _tekstPitanja = value;
        }

        public string konstrukcijaPitanja()
        {
            string pitanje;
            pitanje = _tekstPitanja + "|" + _a + "|" + _b + "|" + _c + "|" + _d + "|" + _tocanOdgovor;
            return pitanje;
        }
    }
}