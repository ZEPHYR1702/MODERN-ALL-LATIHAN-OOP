using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODERN_ALL_LATIHAN_OOP.Classes
{
    public class OvoClass
    {
        private string nama;
        private int ovoCash;
        private int ovoPoints;
        private int nomorTelpon;
        private string ovoID;
        private int pin;

        public OvoClass(string name, int phoneNumber, int pin, string ovoID)
        {
            Nama = name;
            NomorTelpon = phoneNumber;
            Pin = pin;
            OvoID = ovoID;
            OvoCash = 0;
            OvoPoints = 0;
        }

        #region Properties
        public int OvoCash { get => ovoCash; set => ovoCash = value; }
        public int OvoPoints { get => ovoPoints; set => ovoPoints = value; }
        public string Nama
        {
            get => nama;
            set
            {
                if (value != "")
                {
                    nama = value;
                }
                else
                {
                    throw new Exception("Nama tidak boleh kosong");
                }
            }
        }

        public int NomorTelpon
        {
            get => nomorTelpon;
            set
            {
                if (value != 0 && value >= 0)
                {
                    nomorTelpon = value;
                }
                else
                {
                    throw new Exception("Nomor telpon tidak boleh kosong");
                }
            }
        }
        public string OvoID
        {
            get => ovoID;
            set
            {
                if (value != "")
                {
                    ovoID = value;
                }
                else
                {
                    throw new Exception("Ovo ID tidak boleh kosong");
                }
            }
        }
        public int Pin
        {
            get => pin;
            set
            {
                if (value != 0)
                {
                    pin = value;
                }
                else
                {
                    throw new Exception("PIN tidak boleh kosong");
                }
            }
        }
        #endregion

        #region Method
        public void TopUp(int nominal)
        {
            if (nominal < 10000)
            {
                throw new Exception("Minimal top up adalah 10000");
            }
            else
            {
                OvoCash += nominal;
            }
        }

        public void Buy(int nominal)
        {
            if (OvoCash >= nominal)
            {
                if (nominal < 5000)
                {
                    throw new Exception("Minimal transaksi adalah 5000");
                }
                else
                {
                    OvoCash -= nominal;
                    OvoPoints += (nominal / 100);
                }
            }
            else
            {
                throw new Exception("Saldo anda tidak cukup");
            }
        }

        public void Register(string nama, int noTelpon, int pin, string ovoID)
        {
            Nama = nama;
            NomorTelpon = noTelpon;
            Pin = pin;
            OvoID = ovoID;
            OvoCash = 0;
            OvoPoints = 0;
        }

        public string DisplayData()
        {
            string data =
                $"Nama: {this.Nama}\n" +
                $"Nomor Telpon: {this.NomorTelpon}\n" +
                $"OVO ID: {this.OvoID}\n" +
                $"OVO Cash: {this.OvoCash}\n" +
                $"OVO Points: {this.OvoPoints}";
            return data;
        }
        #endregion
    }
}
