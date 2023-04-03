
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pemrogprak3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mobil mobil1 = new mobil();

            mobil1.Warna = "Merah";
            mobil1.JumlahPintu = 3;
            mobil1.Merk = "Zuzuki";
            mobil1.Model = "Carry Wagon";
            mobil1.TahunKeluar = 2004;

            mobil1.Gas(70);
            mobil1.Klakson("entotototot");
            mobil1.tampilkaninfo();

            mobil mobil2 = new mobil();

            mobil2.Warna = "Hitam";
            mobil2.JumlahPintu = 2;
            mobil2.Merk = "Lamborghini";
            mobil2.Model = "aventador";
            mobil2.TahunKeluar = 2018;

            mobil2.Gas(300);
            mobil2.Klakson("wiuwiwuwiwu");
            mobil2.tampilkaninfo();


            Console.Write("Tekan <ESC> untuk keluar");
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }
        }
    }
}
