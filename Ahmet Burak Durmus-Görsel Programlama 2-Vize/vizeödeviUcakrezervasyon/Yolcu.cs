using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vizeödeviUcakrezervasyon
{
    public partial class Yolcu : Form
    {
        public Yolcu()
        {
            InitializeComponent();
        }
        private string _koltukNo;

        public Yolcu(string koltukNo)
        {
            InitializeComponent();
            _koltukNo = koltukNo;
        }
        Ucak_rezervasyonSonEntities db = new Ucak_rezervasyonSonEntities();
        private void Yolcu_Load(object sender, EventArgs e)
        {
            label8.Text = _koltukNo;
        }

        private void btnRezerve_Click(object sender, EventArgs e)
        {
            U_YOLCU yolcu = new U_YOLCU();
            yolcu.İsim = txtAd.Text;
            yolcu.Yas = txtYaş.Text;
            yolcu.Cinsiyet = txtCinsiyet.Text;
            yolcu.Yaşlı_Mı = txtYaşlı.Text;
            yolcu.Engelli_Mi = txtEngelli.Text;
            yolcu.Koltuk_No = label8.Text;
            db.U_YOLCU.Add(yolcu);
            db.SaveChanges();
            MessageBox.Show("Tamamdır");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
