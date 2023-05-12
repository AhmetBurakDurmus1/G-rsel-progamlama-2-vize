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
    public partial class Uçak : Form
    {
        public Uçak()
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

        private void Uçak_Load(object sender, EventArgs e)
        {
            dataGridViewUcak.DataSource = (from x in db.U_Ucak
                                           select new
                                           {
                                               x.Ucak_Id,
                                               x.Ucak_Ad,
                                               x.Koltuk_Sayısı,
                                           }).ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            U_Ucak ucak = new U_Ucak();
            ucak.Ucak_Ad = txtUcakAd.Text;
            ucak.Koltuk_Sayısı = int.Parse(txtKapasite.Text.ToString());
            db.U_Ucak.Add(ucak);
            db.SaveChanges();
            MessageBox.Show("Uçak Eklendi");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtId.Text);
            var ucak = db.U_Ucak.Find(x);
            ucak.Ucak_Ad = txtUcakAd.Text;
            ucak.Koltuk_Sayısı = int.Parse(txtKapasite.Text.ToString());
            db.SaveChanges();
            MessageBox.Show("Uçak Güncellendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtId.Text);
            var ucak = db.U_Ucak.Find(x);
            db.U_Ucak.Remove(ucak);
            db.SaveChanges();
            MessageBox.Show("Uçak Silindi");
        }

        private void dataGridViewUcak_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridViewUcak.SelectedCells[0].RowIndex;

            txtId.Text = dataGridViewUcak.Rows[selected].Cells[0].Value.ToString();
            txtUcakAd.Text = dataGridViewUcak.Rows[selected].Cells[1].Value.ToString();
            txtKapasite.Text = dataGridViewUcak.Rows[selected].Cells[2].Value.ToString();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            dataGridViewUcak.DataSource = (from x in db.U_Ucak
                                           select new
                                           {
                                               x.Ucak_Id,
                                               x.Ucak_Ad,
                                               x.Koltuk_Sayısı,
                                           }).ToList();
        }
    }
}
