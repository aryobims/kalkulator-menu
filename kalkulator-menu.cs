using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulatormenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //deklarasi untuk menu kalkulator 
            int pilih;
            float jawaban, pertama, kedua;

            Console.WriteLine("======================================");
            Console.WriteLine("======  Kalkulator dengan Menu  ======");
            Console.WriteLine("=======  Aryo Bimo/21.11.4311  =======");
            Console.WriteLine("======================================");
            Console.WriteLine("=                                    =");
            Console.WriteLine("=  Pilih menu :                      =");
            Console.WriteLine("=                                    =");
            Console.WriteLine("= 1.Penambahan                       =");
            Console.WriteLine("= 2.Penguranagan                     =");
            Console.WriteLine("= 3.perkalian                        =");
            Console.WriteLine("= 4.Pembagian                        =");
            Console.WriteLine("= 5.Keluar                           =");
            Console.WriteLine("=                                    =");
            Console.WriteLine("======================================\n");

            //proses input pilihan menu
            Console.Write("Masukkan menu pilihan anda (1-4) : ");
            pilih = Convert.ToInt16(Console.ReadLine());

            switch (pilih)
            {
                //percabangan switch case untuk menu penjumlahan
                case 1:
                    Console.WriteLine("\nAnda memilih menu Penjumlahan");
                    Console.Write("Silakan masukkan angka pertama : ");
                    pertama = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Silakan masukkan angka kedua : ");
                    kedua = Convert.ToSingle(Console.ReadLine());
                    jawaban = pertama + kedua;
                    Console.Write("\nJawaban = " + jawaban);
                    Console.ReadKey();
                    break;

                //percabangan switch case untuk menu pengurangan    
                case 2:
                    Console.WriteLine("\nAnda memilih menu Pengurangan");
                    Console.Write("Silakan masukkan angka pertama : ");
                    pertama = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Silakan masukkan angka kedua : ");
                    kedua = Convert.ToSingle(Console.ReadLine());
                    jawaban = pertama - kedua;
                    Console.Write("\nJawaban = " + jawaban);
                    Console.ReadKey();
                    break;

                //percabangan switch case untuk menu perkalian    
                case 3:
                    Console.WriteLine("\nAnda memilih menu Perkalian");
                    Console.Write("Silakan masukkan angka pertama : ");
                    pertama = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Silakan masukkan angka kedua : ");
                    kedua = Convert.ToSingle(Console.ReadLine());
                    jawaban = pertama * kedua;
                    Console.Write("\nJawaban = " + jawaban);
                    Console.ReadKey();
                    break;

                //percabangan switch case untuk menu pembagian
                case 4:
                    Console.WriteLine("\nAnda memilih menu Pembagian");
                    Console.Write("Silakan masukkan angka pertama : ");
                    pertama = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Silakan masukkan angka kedua : ");
                    kedua = Convert.ToSingle(Console.ReadLine());
                    jawaban = pertama / kedua;
                    Console.Write("\nJawaban = " + jawaban);
                    Console.ReadKey();
                    break;

                //percabangan switch case untuk menu keluar   
                case 5:
                    Console.Write("\nTerima kasih, Selamat tinggal");
                    Console.ReadKey();
                    break;

                //default case apabila input tidak sesuai dengan menu pilihan yang diminta
                default:
                    Console.WriteLine("\nInputan anda salah, mohon ulang inputan anda!");
                    Console.ReadKey();
                    break;
            }
        }
    }
}