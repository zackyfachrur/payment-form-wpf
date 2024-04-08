using System.Drawing.Text;
using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace pencarianDekstop
{

    public partial class Form1 : Form
    {

        private long noDaftar;
        private string nama;
        private long telepon;
        private int biayaWeb = 1000000;
        private int biayaNetwork = 800000;
        private int biayaNET = 980000;
        private int biayaKursus = 250000;
        private int totalBayar;
        private int totalCicilan;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HidePaymentLabels();
        }

        private void HidePaymentLabels()
        {
            textBoxTotalCicilan.Hide();
            textBoxTotalBayar.Hide();
            labelTotalCicil.Hide();
            labelTotalBayar.Hide();
        }

        private void AcceptForm()
        {
            try
            {
                noDaftar = long.Parse(textBoxNo.Text);
            }
            catch 
            {
                MessageBox.Show("Terjadi Kesalahan Pada Nomor Pendaftaran");
            }
            if (nama == null)
            {
                try
                {
                    nama = textBoxNama.Text;
                }
                catch
                {
                    MessageBox.Show("Terjadi Kesalahan Pada Nama Pendaftaran");
                }
            }
            try
            {
                telepon = long.Parse(textBoxTelepon.Text);
            }
            catch
            {
                MessageBox.Show("Terjadi Kesalahan Pada Nomor Telepon");
            };
        }

        private int ResultRadio(int biayaDaftar, int biayaPilihan) {
            int result = biayaDaftar + biayaPilihan;
            return result;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            AcceptForm();
            if (radioButtonWeb.Checked)
            {
                totalBayar = ResultRadio(biayaKursus, biayaWeb);
            }
            else if (radioButtonNetwork.Checked)
            {
                totalBayar = ResultRadio(biayaKursus, biayaNetwork);
            }
            else if (radioButtonNET.Checked)
            {
                totalBayar = ResultRadio(biayaKursus, biayaNET);
            }

            if (radioButtonCash.Checked)
            {
                textBoxTotalCicilan.Hide();
                labelTotalCicil.Hide();
            }
            else if (radioButtonCicil.Checked)
            {
                totalCicilan = totalBayar / 3;
                textBoxTotalCicilan.Text = "Rp . " + totalCicilan.ToString();
                textBoxTotalCicilan.Show();
                labelTotalCicil.Show();
            }

            textBoxTotalBayar.Text = "Rp. " + totalBayar.ToString();
            labelTotalBayar.Show();
            textBoxTotalBayar.Show();
        }

        private void clearForm()
        {
            textBoxNo.Clear();
            textBoxNama.Clear();
            textBoxTelepon.Clear();
            radioButtonWeb.Checked = false;
            radioButtonNetwork.Checked = false;
            radioButtonNET.Checked = false; 
            radioButtonCash.Checked = false;
            radioButtonCicil.Checked = false;
            HidePaymentLabels();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }
    }
}
