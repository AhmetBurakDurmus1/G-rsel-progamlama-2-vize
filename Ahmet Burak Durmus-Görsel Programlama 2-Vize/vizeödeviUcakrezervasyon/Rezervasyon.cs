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
    public partial class rezervasyon : Form
    {
        public rezervasyon()
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

        private void rezervasyon_Load(object sender, EventArgs e)
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
            int seferId = Convert.ToInt32(cmbSefer.SelectedValue);
            int uckId = (int)cmbSefer.SelectedValue;
            int koltukSayisi = db.U_Ucak.FirstOrDefault(x => x.Ucak_Id == uckId)?.Koltuk_Sayısı ?? 0;
            dataGridViewSeferler.DataSource = (from x in db.U_SEFERLER
                                               where x.Sefer_Id == seferId
                                               select new
                                               {
                                                   x.Kalkış_Yer,
                                                   x.Varış_Yer,
                                                   x.Kalkış_Tarih,
                                                   x.Varıs_Tarih,
                                                   x.Ücret
                                               }).ToList();

            // Mevcut butonları temizle
            koltuklar.Controls.Clear();

            // Butonları yeniden oluştur
            int koltukGenisligi = 40;
            int koltukYuksekligi = 40;
            int koltukBosluk = 10;
            int siraSayisi = 10;
            char harf = 'A';
            int koltukNo = 1;
            for (int i = 0; i < koltukSayisi; i++)
            {
                Button btn = new Button();
                btn.Click += new EventHandler(btn_Click);
                koltuklar.Controls.Add(btn);
                btn.Name = $"{harf}{koltukNo}";
                btn.Text = $"{harf}{koltukNo}";
                btn.Width = koltukGenisligi;
                btn.Height = koltukYuksekligi;
                int sira = i / siraSayisi;
                int sutun = i % siraSayisi;
                btn.Top = sira * (koltukYuksekligi + koltukBosluk) + 20;
                btn.Left = sutun * (koltukGenisligi + koltukBosluk) + 20;
                btn.BackColor = Color.Green;
                koltuklar.Controls.Add(btn);
                koltukNo++;
                if (koltukNo > 5)
                {
                    koltukNo = 1;
                    harf++;
                }
            }

        }

        private void koltuklar_Enter(object sender, EventArgs e)
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
    }
}
