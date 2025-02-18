namespace DataPelanggan
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Tombol_Hapus = new System.Windows.Forms.Button();
            this.Tombol_Ubah = new System.Windows.Forms.Button();
            this.Tombol_Simpan = new System.Windows.Forms.Button();
            this.harga = new System.Windows.Forms.TextBox();
            this.barang = new System.Windows.Forms.TextBox();
            this.tanggal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataTable);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabel Data Pelanggan";
            // 
            // DataTable
            // 
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Location = new System.Drawing.Point(7, 20);
            this.DataTable.Name = "DataTable";
            this.DataTable.Size = new System.Drawing.Size(763, 142);
            this.DataTable.TabIndex = 0;
            this.DataTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTable_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Tombol_Hapus);
            this.groupBox2.Controls.Add(this.Tombol_Ubah);
            this.groupBox2.Controls.Add(this.Tombol_Simpan);
            this.groupBox2.Controls.Add(this.harga);
            this.groupBox2.Controls.Add(this.barang);
            this.groupBox2.Controls.Add(this.tanggal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nama);
            this.groupBox2.Location = new System.Drawing.Point(12, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 234);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Data Pelanggan";
            // 
            // Tombol_Hapus
            // 
            this.Tombol_Hapus.Location = new System.Drawing.Point(602, 91);
            this.Tombol_Hapus.Name = "Tombol_Hapus";
            this.Tombol_Hapus.Size = new System.Drawing.Size(127, 41);
            this.Tombol_Hapus.TabIndex = 10;
            this.Tombol_Hapus.Text = "Hapus";
            this.Tombol_Hapus.UseVisualStyleBackColor = true;
            this.Tombol_Hapus.Click += new System.EventHandler(this.Tombol_Hapus_Click);
            // 
            // Tombol_Ubah
            // 
            this.Tombol_Ubah.Location = new System.Drawing.Point(469, 91);
            this.Tombol_Ubah.Name = "Tombol_Ubah";
            this.Tombol_Ubah.Size = new System.Drawing.Size(127, 41);
            this.Tombol_Ubah.TabIndex = 9;
            this.Tombol_Ubah.Text = "Ubah";
            this.Tombol_Ubah.UseVisualStyleBackColor = true;
            this.Tombol_Ubah.Click += new System.EventHandler(this.button2_Click);
            // 
            // Tombol_Simpan
            // 
            this.Tombol_Simpan.Location = new System.Drawing.Point(336, 91);
            this.Tombol_Simpan.Name = "Tombol_Simpan";
            this.Tombol_Simpan.Size = new System.Drawing.Size(127, 41);
            this.Tombol_Simpan.TabIndex = 8;
            this.Tombol_Simpan.Text = "Simpan";
            this.Tombol_Simpan.UseVisualStyleBackColor = true;
            this.Tombol_Simpan.Click += new System.EventHandler(this.Tombol_Simpan_Click);
            // 
            // harga
            // 
            this.harga.Location = new System.Drawing.Point(128, 156);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(165, 20);
            this.harga.TabIndex = 7;
            // 
            // barang
            // 
            this.barang.Location = new System.Drawing.Point(128, 112);
            this.barang.Name = "barang";
            this.barang.Size = new System.Drawing.Size(165, 20);
            this.barang.TabIndex = 6;
            // 
            // tanggal
            // 
            this.tanggal.Location = new System.Drawing.Point(128, 68);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(165, 20);
            this.tanggal.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Harga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tanggal Transaksi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama Pelanggan";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(128, 28);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(165, 20);
            this.nama.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Data Pelanggan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.Button Tombol_Hapus;
        private System.Windows.Forms.Button Tombol_Ubah;
        private System.Windows.Forms.Button Tombol_Simpan;
        private System.Windows.Forms.TextBox harga;
        private System.Windows.Forms.TextBox barang;
        private System.Windows.Forms.TextBox tanggal;
    }
}

