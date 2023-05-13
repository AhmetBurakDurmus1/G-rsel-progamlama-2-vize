namespace vizeödeviUcakrezervasyon
{
    partial class rezervasyon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbSefer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anaMenüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnYenile = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewSeferler = new System.Windows.Forms.DataGridView();
            this.koltuklar = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeferler)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSefer
            // 
            this.cmbSefer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSefer.FormattingEnabled = true;
            this.cmbSefer.Location = new System.Drawing.Point(138, 55);
            this.cmbSefer.Name = "cmbSefer";
            this.cmbSefer.Size = new System.Drawing.Size(222, 21);
            this.cmbSefer.TabIndex = 19;
            this.cmbSefer.SelectedIndexChanged += new System.EventHandler(this.cmbSefer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-79, -31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sefer Seçin:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaMenüToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1073, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anaMenüToolStripMenuItem
            // 
            this.anaMenüToolStripMenuItem.Name = "anaMenüToolStripMenuItem";
            this.anaMenüToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.anaMenüToolStripMenuItem.Text = "AnaMenü";
            this.anaMenüToolStripMenuItem.Click += new System.EventHandler(this.anaMenüToolStripMenuItem_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(652, 27);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(246, 49);
            this.btnYenile.TabIndex = 22;
            this.btnYenile.Text = "Yolcu Getir";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewSeferler);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(22, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 260);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sefer Bilgileri";
            // 
            // dataGridViewSeferler
            // 
            this.dataGridViewSeferler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeferler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSeferler.Location = new System.Drawing.Point(3, 25);
            this.dataGridViewSeferler.Name = "dataGridViewSeferler";
            this.dataGridViewSeferler.Size = new System.Drawing.Size(395, 232);
            this.dataGridViewSeferler.TabIndex = 0;
            // 
            // koltuklar
            // 
            this.koltuklar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.koltuklar.Location = new System.Drawing.Point(450, 82);
            this.koltuklar.Name = "koltuklar";
            this.koltuklar.Size = new System.Drawing.Size(549, 472);
            this.koltuklar.TabIndex = 20;
            this.koltuklar.TabStop = false;
            this.koltuklar.Text = "Koltuklar";
            this.koltuklar.Enter += new System.EventHandler(this.koltuklar_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Sefer Seçin:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(25, 357);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 215);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yolcu Bilgileri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(397, 187);
            this.dataGridView1.TabIndex = 0;
            // 
            // rezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1073, 571);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.koltuklar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSefer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "rezervasyon";
            this.Text = "rezervasyon";
            this.Load += new System.EventHandler(this.rezervasyon_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeferler)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbSefer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anaMenüToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewSeferler;
        private System.Windows.Forms.GroupBox koltuklar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}