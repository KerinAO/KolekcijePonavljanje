using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolekcijePonavljanje
{
    public class Vozilo
    {
        string Model;
        int GodinaProizvodnje;
        int BrojKotaca;
        string Dodatak;

        public Vozilo(string model, int godinaProizvodnje, int brojKotaca, string dodatak)
        {
            this.Model = model;
            this.GodinaProizvodnje = godinaProizvodnje;
            this.BrojKotaca = brojKotaca;
            this.Dodatak = dodatak;
        }

        public string Model1 { get => Model; set => Model = value; }
        public int GodinaProizvodnje1 { get => GodinaProizvodnje; set => GodinaProizvodnje = value; }
        public int BrojKotaca1 { get => BrojKotaca; set => BrojKotaca = value; }

        public string Dodatak1 { get => Dodatak; set => Dodatak = value; }

        public override string ToString()
        {
            string ispis = this.Model + "\t" + this.GodinaProizvodnje + "\t\t" + this.BrojKotaca + "\t\t" + this.Dodatak;
            return ispis;
        }
    }
}
