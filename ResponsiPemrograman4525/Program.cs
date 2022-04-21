using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4525
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nik\t\t\t Nama \t\t\t GajiBulana");
            Console.WriteLine("--------------------------------");

            Karyawan karyawan1 = new Karyawan(190302123, "Paijo", 3000000);
            Karyawan karyawan2 = new Karyawan(190302124, "Jono", 2000000);
            karyawan1.Nik = 190302123;
            karyawan2.Nik = 190302124;
            karyawan1.Nama = "Paijo";
            karyawan2.Nama = "Jono";
            karyawan1.GajiBulanan = 3000000;
            karyawan2.GajiBulanan = 2000000;

            karyawan1.PrintAndShow();
            karyawan2.PrintAndShow();
            Console.WriteLine("Asyikkkk kenaikan gaji 10%");
            Console.WriteLine("\n\nNIK\t\t\t Nama \t\t\t GajiBulanan");
            Console.WriteLine("-------------------------------------");

            karyawan1.Nik = 190302123;
            karyawan2.Nik = 190302124;
            karyawan1.Nama = "Paijo";
            karyawan2.Nama = "Jono";
            karyawan1.GajiBulanan = 3000000;
            karyawan2.GajiBulanan = 2000000;

            karyawan1.getdapetbonus();
            karyawan2.getdapetbonus();

            Console.ReadKey();
        }
    }
}