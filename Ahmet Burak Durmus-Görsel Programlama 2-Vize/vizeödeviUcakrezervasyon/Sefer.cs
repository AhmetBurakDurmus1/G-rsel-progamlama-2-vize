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
    public partial class Sefer : Form
    {
        public Sefer()
        {
            InitializeComponent();
        }

        Ucak_rezervasyonSonEntities db = new Ucak_rezervasyonSonEntities();

        private void anaMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaMenü fr = new AnaMenü();
            fr.Show();
            this.Hide();
        }

        private void Sefer_Load(object sender, EventArgs e)
        {
            dataGridViewSefer.DataSource = (from x in db.U_SEFERLER
                                            join u in db.U_Ucak on x.Ucak_Id equals u.Ucak_Id
                                            select new
                                            {
                                                x.Sefer_Id,
                                                x.Kalkış_Yer,
                                                x.Varış_Yer,
                                                x.Kalkış_Tarih,
                                                x.Varıs_Tarih,
                                                Ucak_Ad = u.Ucak_Ad,
                                                x.Ücret,
                                                x.Sefer_Ad
                                            }).ToList();

            cmbUçak.DisplayMember = "Ucak_Ad";
            cmbUçak.ValueMember = "Ucak_Id";

            cmbUçak.DataSource = db.U_Ucak.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            U_SEFERLER sefer = new U_SEFERLER();
            sefer.Kalkış_Yer = cmbKalkışYer.Text;
            sefer.Varış_Yer = cmbVarışYer.Text;
            sefer.Kalkış_Tarih = kalkışZaman.Text;
            sefer.Varıs_Tarih = varışZaman.Text;
            sefer.Ucak_Id = int.Parse(cmbUçak.SelectedValue.ToString());
            sefer.Sefer_Ad = txtSeferAd.Text;
            sefer.Ücret = txtÜcret.Text;
            db.U_SEFERLER.Add(sefer);
            db.SaveChanges();
            MessageBox.Show("Sefer Eklendi");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(labelId.Text);
            var sefer = db.U_SEFERLER.Find(x);
            sefer.Kalkış_Yer = cmbKalkışYer.Text;
            sefer.Varış_Yer = cmbVarışYer.Text;
            sefer.Kalkış_Tarih = kalkışZaman.Text;
            sefer.Varıs_Tarih = varışZaman.Text;
            sefer.Ucak_Id = int.Parse(cmbUçak.SelectedValue.ToString());
            sefer.Sefer_Ad = txtSeferAd.Text;
            sefer.Ücret = txtÜcret.Text;
            db.SaveChanges();
            MessageBox.Show("Sefer Güncellendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(labelId.Text);
            var sefer = db.U_SEFERLER.Find(x);
            db.U_SEFERLER.Remove(sefer);
            db.SaveChanges();
            MessageBox.Show("Sefer Silindi");
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            dataGridViewSefer.DataSource = (from x in db.U_SEFERLER
                                            join u in db.U_Ucak on x.Ucak_Id equals u.Ucak_Id
                                            select new
                                            {
                                                x.Sefer_Id,
                                                x.Kalkış_Yer,
                                                x.Varış_Yer,
                                                x.Kalkış_Tarih,
                                                x.Varıs_Tarih,
                                                Ucak_Ad = u.Ucak_Ad,
                                                x.Ücret,
                                                x.Sefer_Ad
                                            }).ToList();

            cmbUçak.DisplayMember = "Ucak_Ad";
            cmbUçak.ValueMember = "Ucak_Id";

            cmbUçak.DataSource = db.U_Ucak.ToList();
        }

        private void dataGridViewSefer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridViewSefer.SelectedCells[0].RowIndex;

            labelId.Text = dataGridViewSefer.Rows[selected].Cells[0].Value.ToString();
            cmbKalkışYer.Text = dataGridViewSefer.Rows[selected].Cells[1].Value.ToString();
            cmbVarışYer.Text = dataGridViewSefer.Rows[selected].Cells[2].Value.ToString();
            kalkışZaman.Text = dataGridViewSefer.Rows[selected].Cells[3].Value.ToString();
            varışZaman.Text = dataGridViewSefer.Rows[selected].Cells[4].Value.ToString();
            cmbUçak.SelectedIndex = cmbUçak.FindStringExact(dataGridViewSefer.Rows[selected].Cells[5].Value.ToString());
            txtÜcret.Text = dataGridViewSefer.Rows[selected].Cells[6].Value.ToString();
            txtSeferAd.Text = dataGridViewSefer.Rows[selected].Cells[7].Value.ToString();

        }
    }
}
