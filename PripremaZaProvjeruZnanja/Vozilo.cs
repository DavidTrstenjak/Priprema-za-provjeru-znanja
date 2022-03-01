using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaZaProvjeruZnanja
{
    internal class Vozilo
    {
        String vrsta, naziv, marka;
        DateTime GodPro;
        int snaga;

        public string Vrsta { get => vrsta; set => vrsta = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Marka { get => marka; set => marka = value; }
        public DateTime GodPro1 { get => GodPro; set => GodPro = value; }
        public int Snaga { get => snaga; set => snaga = value; }

        public Vozilo(string vrsta, string naziv, string marka, DateTime godPro, int snaga) { 
            Vrsta = vrsta;
            Naziv = naziv;
            Marka = marka;
            GodPro = godPro;
            Snaga = snaga;
        }

        public override string ToString()
        {
            string ispis = "Vrsta: " + this.Vrsta + " Marka: " + this.Marka + " Naziv: " + this.Naziv + " Godina proizvodnje: " + this.GodPro1.Year +
                " Snaga: " + this.Snaga + " KS" + "\n";
            return ispis;
        }
    }
}
