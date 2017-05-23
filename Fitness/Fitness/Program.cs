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
                //keluarkan pertanyaanya
                Console.WriteLine("Berapa lama lari?");

                //minta input dari user
                input = Console.ReadLine();
                
                //menambahkan inputnya
                jumlah = jumlah + Int32.Parse(input);

                if (input == "quit")
                {
                    break;
                }
                
                //ngerlurin inputnya
                Console.WriteLine("Selamat anda sudah lari " + jumlah + "menit");

            }
            



        }
    }
}
