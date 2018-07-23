﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Models
{
    class Product : BasicServerModel
    {
        public string namaProduk;
        public string jumlah;
        public string jenisSatuan;
        public int harga;

        public Product(string namaProduk, string jumlah, string jenisSatuan, int harga) {
            this.namaProduk = namaProduk;
            this.jumlah = jumlah;
            this.jenisSatuan = jenisSatuan;
            this.harga = harga;
            
        }
    }
}
