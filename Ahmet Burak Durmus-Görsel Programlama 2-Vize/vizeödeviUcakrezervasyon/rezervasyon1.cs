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
    public partial class rezervasyon1 : Form
    {
        public rezervasyon1()
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

        private void Rezervasyon_Load(object sender, EventArgs e)
        {
            cmbSefer.DisplayMember = "Sefer_Ad";
            cmbSefer.ValueMember = "Sefer_Id";

            cmbSefer.DataSource = db.U_SEFERLER.ToList();
        }

        private string koltukNo;
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {

                koltukNo = btn.Text;

                Yolcu fr = new Yolcu(koltukNo);
                fr.Show();
            }
        }
        private void cmbSefer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.U_YOLCU
                                        select new
                                        {
                                            x.Yolcu_Id,
                                            x.İsim,
                                            x.Yas,
                                            x.Cinsiyet,
                                            x.Yaşlı_Mı,
                                        }).ToList();
        }
        private void rezervasyon1_Load(object sender, EventArgs e)
        {

        }
        private void koltuklar_Enter(object sender, EventArgs e)
        {



        }
    }
}
