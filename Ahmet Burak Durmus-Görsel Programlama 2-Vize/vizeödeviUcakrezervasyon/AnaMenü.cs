using Antlr.Runtime;
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
    public partial class AnaMenü : Form
    {
        public AnaMenü()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Uçak fr = new Uçak();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sefer fr = new Sefer();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rezervasyon fr = new rezervasyon();
            fr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void AnaMenü_Load(object sender, EventArgs e)
        {

        }
    }
}
