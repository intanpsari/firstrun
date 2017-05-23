using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness
{
    class Program
    {
        static void Main(string[] args)
        {
            String input="";
            int jumlah = 0;

            //looping
            //keluar bila user masukkin "quit"

            while (true)
            {
                try
                {
                    //keluarkan pertanyaanya
                    Console.WriteLine("Berapa lama lari?");

                    //minta input dari user
                    input = Console.ReadLine();

                    //jika quit maka break
                    if (input.ToLower() == "quit")
                    {
                        break;
                    }

                    //jika input minus
                    if (Int32.Parse(input) < 0)
                    {
                        Console.WriteLine("Mohon input dengan benar");
                        continue; //ngulang dari atas while
                    }

                    //menambahkan inputnya
                    jumlah = jumlah + Int32.Parse(input);

                    //ngerlurin inputnya
                    Console.WriteLine("Selamat anda sudah lari " + jumlah + " menit");
                }
                catch(Exception)
                {
                    Console.WriteLine("Mohon input dengan benar");
                    continue; //ngulang dari atas while
                }
            }

        }
    }
}
