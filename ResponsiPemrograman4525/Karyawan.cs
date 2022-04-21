using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4525
{
    internal class Karyawan
    {
        public int Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }
        public int Gajinaik { get; set; }

        public Karyawan(int Nik, string Nama, int GajiBulanan)
        {
            Nik = Nik;
            Nama = Nama;
            GajiBulanan = GajiBulanan;
            Gajinaik = 10;
            if (GajiBulanan < 0)
            {
                GajiBulanan = 0;
            }
        }

        public void getdapetbonus()
        {
            int bonus = GajiBulanan / GajiBulanan;
            GajiBulanan = GajiBulanan + bonus;
            Console.WriteLine("{0} \t{1}\t\t\t {2}", Nik, Nama, GajiBulanan);
        }
        public void PrintAndShow()
        {
            Console.WriteLine("{0} \t{1}\t\t\t {2}", Nik, Nama, GajiBulanan);
        }
    }
}
