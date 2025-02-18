using DataPelanggan.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataPelanggan.controller
{
    class Pelanggan
    {
        // Memanggil Class Koneksi
        Koneksi koneksi = new Koneksi();

        // Fungsi Insert atau Membuat Data (Create)
        public bool Insert(Pelanggan_m pelanggan)
        {
            Boolean status = false;

            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO pelanggan (nama, tanggal, barang, harga) VALUES ('" + pelanggan.Nama + "', '" + pelanggan.Tanggal + "', '" + pelanggan.Barang + "', '" + pelanggan.Harga + "')");
                status = true;
                MessageBox.Show("Data Berhasil Ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }


        // Fungsi Update atau Mengubah Data (Update)
        public bool Update(Pelanggan_m pelanggan, string id)
        {
            Boolean status = false;

            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE pelanggan SET nama='" + pelanggan.Nama + "', " + "tanggal='" + pelanggan.Tanggal + "', " + "barang='" + pelanggan.Barang + "', " + "harga='" + pelanggan.Harga + "' WHERE id='" + id + "' ");
                status = true;
                MessageBox.Show("Data Berhasil Diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        // Fungsi Delete atau Menghapus Data
        public bool Delete(string id)
        {
            Boolean status = false;

            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM pelanggan WHERE id ='" + id + "'");
                status = true;
                MessageBox.Show("Data Berhasil Dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

    }
}
