﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Priprema_za_provjeru_znanja_2122
{
    public partial class Form1 : Form
    {
        List<Vozilo> listaVozila = new List<Vozilo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            Vozilo vozilo = new Vozilo(cmbVrsta.Text,
                txtMarka.Text, txtNaziv.Text, 
                dtpGodPro.Value, trckSnaga.Value);

            listaVozila.Add(vozilo);

            MessageBox.Show("Uspješan unos.", "USPJEH!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void trckSnaga_Scroll(object sender, EventArgs e)
        {
            lblSnaga.Text = Convert.ToString(trckSnaga.Value);
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            rtxtIspis.Clear();
            foreach (Vozilo vozilo in listaVozila)
            {
                rtxtIspis.AppendText(vozilo.ToString());
            }
        }
    }
}
