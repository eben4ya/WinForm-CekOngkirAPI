using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ongkir_Form
{
    public partial class Form1 : Form
    {
        List<string> listKota = new List<string>();
        public Form1()
        {
            InitializeComponent();
            listKota = Ongkir.GetKotaList();
            foreach(string kota in listKota)
            {
                tbAsal.AutoCompleteCustomSource.Add(kota);
                tbAsal.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tbAsal.AutoCompleteSource = AutoCompleteSource.CustomSource;
                tbTujuan.AutoCompleteCustomSource.Add(kota);
                tbTujuan.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tbTujuan.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int GetIdKota(string kota)
        {
            int idKota = -1;
            idKota = Ongkir.GetIdKotaList(kota);
            return idKota;
        }

        private void TampilkanDaftar(List<string> daftarLayanan)
        {
            gbDetailServices.Text = "Detail Layanan";
            foreach (string layanan in daftarLayanan)
            {
                gbDetailServices.Text += "\n-" + layanan;
            }
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            string kurir = "";
            if(rbJNE.Checked)
            {
                kurir = "jne";
            }
            else if (rbPOS.Checked)
            {
                kurir = "pos";
            }
            else if (rbTIKI.Checked)
            {
                kurir = "tiki";
            }
            
            List<string> daftarLayanan = Ongkir.GetLayananList(GetIdKota(tbAsal.Text), GetIdKota(tbTujuan.Text), int.Parse(tbWeight.Text),kurir);

            TampilkanDaftar(daftarLayanan);

        }
    }
}
