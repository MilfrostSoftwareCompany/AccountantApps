﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Models
{
    public class Customer : BasicServerModel
    {
        public string nama;
        public string alamat;
        public string telepon;
        public string id;

        public Customer(DataRow dataRow)
        {
            this.id = dataRow[0].ToString(); ;
            this.nama = dataRow[1].ToString();
            this.alamat = dataRow[2].ToString();
            this.telepon = dataRow[3].ToString();
        }

        public Customer(string id,string nama, string alamat, string telepon)
        {
            this.nama = nama;
            this.alamat = alamat;
            this.telepon = telepon;
            this.id = id;
            this.createdBy = Login.loggedUser;
            this.creationTime = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
        }

        public Customer(string nama, string alamat, string telepon)
        {
            this.nama = nama;
            this.alamat = alamat;
            this.telepon = telepon;
            this.createdBy = Login.loggedUser;
            this.creationTime = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
        }
    }
}
