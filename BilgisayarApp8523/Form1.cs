﻿using BilgisayarApp8523.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgisayarApp8523
{
    public partial class Form1 : Form
    {
        Bilgisayar bilgisayar;
        public Form1()
        {
            InitializeComponent();
        }

        private void bOlustur_Click(object sender, EventArgs e)
        {
            //string marka = tbMarka.Text;
            //MessageBox.Show(marka);


            //Bilgisayar bilgisayar = new Bilgisayar();
            //bilgisayar.Id = 1;
            //bilgisayar.Marka = tbMarka.Text;

            bilgisayar = new Bilgisayar()
            {
                Id = 1,
                Marka = tbMarka.Text,
                Model = tbModel.Text,
                GHz = double.Parse(tbHiz.Text),
                Hafiza = Convert.ToInt16(nudHafiza.Value),
                SuSogutmaliMi = cbSuSogutma.Checked,
                Inc = Convert.ToDouble(tbEkran.Text),
                UretimTarihi = dtpUretim.Value,
                BilgisayarTipi = (BilgisayarTipi)ddlBilgisayarTipi.SelectedIndex
            };
            MessageBox.Show("Bilgisayar oluşturuldu");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpUretim.Value = DateTime.Now;
            ddlBilgisayarTipi.SelectedIndex = 0;

        }

        private void bGoster_Click(object sender, EventArgs e)
        {
            //string result = "ID :  " + bilgisayar.Id + "\r\n" +
            //                "Marka : " + bilgisayar.Marka + "\r\n" +
            //                "Model : " + bilgisayar.Model;

            string result = "";
            result += "ID : " + bilgisayar.Id + "\r\n";
            result += "Marka : " + bilgisayar.Marka + "\r\n";
            result += "Model : " + bilgisayar.Model + "\r\n";
            result += "Hız : " + bilgisayar.GHz + "\r\n";
            result += "Hafıza : " + bilgisayar.Hafiza + "\r\n";
            result += "Ekran : " + bilgisayar.Inc + "\r\n";
            //if (bilgisayar.SuSogutmaliMi)
            //{
            //    result += "Su Soğutma: Evet";
            //}
            //else
            //{
            //    result += "Su Soğutma: Hayır";
            //}
            result += "Su Soğutma : " + (bilgisayar.SuSogutmaliMi ? "Evet" : "Hayır") + "\r\n";
            result += "Üretim Tarihi :" + bilgisayar.UretimTarihi.ToShortDateString() + "\r\n";
            result += "Bilgisayar Tipi :" + bilgisayar.BilgisayarTipi;
            MessageBox.Show(result);
        }
    }
}
