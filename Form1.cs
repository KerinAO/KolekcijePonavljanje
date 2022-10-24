using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KolekcijePonavljanje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Vozilo> auti = new List<Vozilo>();

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtBrojKotaca) % 2 == 0)
            {
                try
                {
                    Vozilo vozilo = new Vozilo(txtModel.Text, Convert.ToInt32(txtGodinaProizvodnje.Text), Convert.ToInt32(txtBrojKotaca.Text), "");

                    auti.Add(vozilo);

                    txtModel.Clear();
                    txtGodinaProizvodnje.Clear();
                    txtBrojKotaca.Clear();

                    MessageBox.Show("Uspješan unos!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception greska)
                {
                    MessageBox.Show("Pogrešan unos!\r\n" + greska.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Broj kotača nesmije biti neparan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            txtIspis.AppendText("Model:" + "\tGodina proizvodnje:" + "\tBroj kotača:" + "\tDodatak:" + "\r\n");
            foreach (Vozilo vozilo in auti)
            {
                txtIspis.AppendText(vozilo.ToString() + "\r\n");
            }
        }

        private void btnObradi_Click(object sender, EventArgs e)
        {
            foreach (Vozilo vozilo in auti)
            {
                if (vozilo.BrojKotaca1.ToString() == "2")
                {
                    vozilo.Dodatak1 = "Motocikl";
                }
                if (vozilo.BrojKotaca1.ToString() == "4")
                {
                    vozilo.Dodatak1 = "Automobil";
                }
                if (vozilo.BrojKotaca1 > 4)
                {
                    vozilo.Dodatak1 = "Kamion";
                }

            }
            foreach (Vozilo vozilo in auti)
            {
                txtIspis.AppendText(vozilo.ToString() + "\r\n");
            }
        }
    }
}
