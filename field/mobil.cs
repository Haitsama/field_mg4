using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace pemrogprak3
{
    internal class mobil
    {
        //field
        private string warna;
        private int jumlahPintu;
        private string merk;
        private string model;
        private int tahunKeluar;


        //propertis
        public string Warna
        {
            get
            {
                return warna;
            }
            set
            {
                warna = value;
            }
        }

        public int JumlahPintu
        {
            get
            {
                return jumlahPintu;
            }
            set
            {
                jumlahPintu = value;
            }
        }

        public string Merk
        {
            get
            {
                return merk;
            }
            set
            {
                merk = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public int TahunKeluar
        {
            get
            {
                return tahunKeluar;
            }
            set
            {
                tahunKeluar = value;
            }
        }
        //method
        public void Gas(int kecepatan)
        {
            Console.WriteLine("========================================================");
            Console.WriteLine("Mobil {0} berjalan dengan kecepatan {1} KM/H", Model, kecepatan);
        }

        public void Klakson(string suara)
        {
            Console.WriteLine("output klakson: {0}\n", suara);
        }

        public void tampilkaninfo()
        {
            Console.WriteLine("Mobil saya berwarna {0},merek {1} model {2} keluaran tahun {3} dengan jumlah pintu sebanyak {4}\n", Warna, Merk, Model, TahunKeluar, JumlahPintu);
        }

    }
}
