﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taksit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double fiyat, taksitsayisi, taksittutari;
            fiyat=Convert.ToDouble(txtFiyat.Text);
            taksitsayisi = Convert.ToDouble(tbTaksitSayisi.Value);
            taksittutari = fiyat / taksitsayisi;

            lblTaksitTutar.Text ="Taksit Tutar: "+ taksittutari.ToString();

        }
    }
}
