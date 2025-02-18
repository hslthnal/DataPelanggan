using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPelanggan.model
{
    class Pelanggan_m
    {
        string nama, tanggal, barang, harga;

        public Pelanggan_m()
        {
        }

        public Pelanggan_m(string nama, string tanggal, string barang, string harga)
        {
            this.nama = nama;
            this.tanggal = tanggal;
            this.barang = barang;
            this.harga = harga;
        }

        public string Nama { get => nama; set => nama = value; }
        public string Tanggal { get => tanggal; set => tanggal = value; }
        public string Barang { get => barang; set => barang = value; }
        public string Harga { get => harga; set => harga = value; }
    }
}
