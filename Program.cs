using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman3402
{
    class Program
    {
        static void Main(string[] args)
        {

            Karyawan karyawan1 = new Karyawan(20113402, "Adhe",     6500000);
            Karyawan karyawan2 = new Karyawan(20113423, "Azam",     5500000);
            Karyawan karyawan3 = new Karyawan(20114673, "Hermawan", 4500000);


            Console.WriteLine("No.\t NIK \t   \t Nama \t   \t\t  Gaji      ");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("1.   {0} \t   \t {1} \t   \t\t {2}     ", karyawan1.nim, karyawan1.nama, karyawan1.gaji);
            Console.WriteLine("2.   {0} \t   \t {1} \t   \t\t {2}     ", karyawan2.nim, karyawan2.nama, karyawan2.gaji);
            Console.WriteLine("3.   {0} \t   \t {1} \t   \t {2}       ", karyawan3.nim, karyawan3.nama, karyawan3.gaji);


            Console.WriteLine("\n Selamat Kamu mendapatkan kenaikan gaji sebesar 10 % \n");


            Console.WriteLine("No. \t NIK \t   \t Nama \t   \t\t  Gaji      ");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("1.   {0} \t   \t {1} \t   \t\t {2}     ", karyawan1.nim, karyawan1.nama, karyawan1.naikGaji);
            Console.WriteLine("2.   {0} \t   \t {1} \t   \t\t {2}     ", karyawan2.nim, karyawan2.nama, karyawan2.naikGaji);
            Console.WriteLine("3.   {0} \t   \t {1} \t   \t {2}     ", karyawan3.nim, karyawan3.nama, karyawan3.naikGaji);


            Console.ReadKey();
        }

    }
}