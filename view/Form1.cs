using DataPelanggan.controller;
using DataPelanggan.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataPelanggan
{
    public partial class Form1: Form
    {
        Koneksi koneksi = new Koneksi();
        Pelanggan_m pelanggan = new Pelanggan_m();
        string id;

        // Menampilakan Data
        public void Tampil()
        {
            DataTable.DataSource = koneksi.ShowData("SELECT * FROM pelanggan");

            DataTable.Columns[0].HeaderText = "#";
            DataTable.Columns[1].HeaderText = "Nama Pelanggan";
            DataTable.Columns[2].HeaderText = "Tanggal Transaksi";
            DataTable.Columns[3].HeaderText = "Nama Barang";
            DataTable.Columns[4].HeaderText = "Harga Barang";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        // Mengatur Tombol Simpan
        private void Tombol_Simpan_Click(object sender, EventArgs e)
        {
            if(nama.Text == "" || tanggal.Text == "" || barang.Text == "" || harga.Text == "")
            {
                MessageBox.Show("Data Tidak Boleh Kosong", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Pelanggan plg = new Pelanggan();
                pelanggan.Nama = nama.Text;
                pelanggan.Tanggal = tanggal.Text;
                pelanggan.Barang = barang.Text;
                pelanggan.Harga = harga.Text;

                plg.Insert(pelanggan);
                nama.Text = "";
                tanggal.Text = "";
                barang.Text = "";
                harga.Text = "";

                Tampil();
            }
        }


        // Mengatur datagrid agar bisa diklik
        private void DataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DataTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            nama.Text = DataTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            tanggal.Text = DataTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            barang.Text = DataTable.Rows[e.RowIndex].Cells[3].Value.ToString();
            harga.Text = DataTable.Rows[e.RowIndex].Cells[4].Value.ToString();

        }


        // Mengatur Tombol Ubah
        private void button2_Click(object sender, EventArgs e)
        {
            if (nama.Text == "" || tanggal.Text == "" || barang.Text == "" || harga.Text == "")
            {
                MessageBox.Show("Data Tidak Boleh Kosong", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Pelanggan plg = new Pelanggan();
                pelanggan.Nama = nama.Text;
                pelanggan.Tanggal = tanggal.Text;
                pelanggan.Barang = barang.Text;
                pelanggan.Harga = harga.Text;

                plg.Update(pelanggan, id);
                nama.Text = "";
                tanggal.Text = "";
                barang.Text = "";
                harga.Text = "";

                Tampil();
            }
        }

        // Mengatur Tombol Hapus
        private void Tombol_Hapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Yakin ingin menghapus?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Pelanggan kr = new Pelanggan();
                kr.Delete(id);
                Tampil();
            }
        }

        private void move_btn_Click(object sender, EventArgs e)
        {
            TestUtama tes = new TestUtama();
            tes.Show();
            this.Hide();

            // TEST
        }
    }
}
