using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool ilkgiris = true;
        string sonislem = "";
        double arasonuc = 0;
        private void btn1_Click(object sender, EventArgs e)
        {
            //Button btn = new Button(); //btn adında yeni boş bir buton oluşturur.
            Button btn = (Button)sender; //Button btn = sender as Button;
            if (ilkgiris)
            {
                txtGiris.Text = btn.Text;
                ilkgiris = false;
            }
            else
                txtGiris.Text += btn.Text;
        }
        private void btnArti_Click(object sender, EventArgs e)
        {
            txtIslem.Text += txtGiris.Text + "+";
            ilkgiris = true;
            if (sonislem == "")
                arasonuc = Convert.ToDouble(txtGiris.Text);
            else
                arasonuc = IslemYap(arasonuc, Convert.ToDouble(txtGiris.Text), sonislem);
            txtGiris.Text = arasonuc.ToString();
            sonislem = "+";
        }
        private void btnEksi_Click(object sender, EventArgs e)
        {
            txtIslem.Text += txtGiris.Text + "-";
            ilkgiris = true;
            if (sonislem == "")
                arasonuc = Convert.ToDouble(txtGiris.Text);
            else
                arasonuc = IslemYap(arasonuc, Convert.ToDouble(txtGiris.Text), sonislem);
            txtGiris.Text = arasonuc.ToString();
            sonislem = "-";
        }
        private void btnCarpi_Click(object sender, EventArgs e)
        {
            txtIslem.Text += txtGiris.Text + "*";
            ilkgiris = true;
            if (sonislem == "")
                arasonuc = Convert.ToDouble(txtGiris.Text);
            else
                arasonuc = IslemYap(arasonuc, Convert.ToDouble(txtGiris.Text), sonislem);
            txtGiris.Text = arasonuc.ToString();
            sonislem = "*";
        }
        private void btnBolu_Click(object sender, EventArgs e)
        {
            txtIslem.Text += txtGiris.Text + "/";
            ilkgiris = true;
            if (sonislem == "")
                arasonuc = Convert.ToDouble(txtGiris.Text);
            else
                arasonuc = IslemYap(arasonuc, Convert.ToDouble(txtGiris.Text), sonislem);
            txtGiris.Text = arasonuc.ToString();
            sonislem = "/";
        }
        private double IslemYap(double OncekiDeger, double SonDeger, string SonIslem)
        {
            double Sonuc = 0;
            switch (SonIslem)
            {
                case "+":
                    Sonuc = OncekiDeger + SonDeger;
                    break;
                case "-":
                    Sonuc = OncekiDeger - SonDeger;
                    break;
                case "*":
                    Sonuc = OncekiDeger * SonDeger;
                    break;
                case "/":
                    Sonuc = OncekiDeger / SonDeger;
                    break;
            }
            return Sonuc;
        }
        private void btnEsittir_Click(object sender, EventArgs e)
        {
            txtIslem.Text = "";
            ilkgiris = true;
            if (sonislem == "")
                arasonuc = Convert.ToDouble(txtGiris.Text);
            else
                arasonuc = IslemYap(arasonuc, Convert.ToDouble(txtGiris.Text), sonislem);
            txtGiris.Text = arasonuc.ToString();
            sonislem = "";
            arasonuc = 0;
        }
    }
}
