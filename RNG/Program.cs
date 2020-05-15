using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNG
{
    class Program
    {
        static bool tekrarlaa = false;
        public static void Oyna(int geliceksans)
        {
            
            Console.WriteLine("sayi gecerli, otomatik yükseltme(1) mi istersiniz tek tek(2) mi? Secim yapmak icin 1 ve 2 yi kullanınız.");
            string deger1 = Console.ReadLine();
            if (deger1 == "1")
            {
                bool dondur = true;
                int sayac = 0;
                Console.WriteLine("otomatik deneme baslıyor :)");

                Random random = new Random();
                while (dondur == true)
                {
                    int random1 = random.Next(0, 101);
                    int gecersayi = 100 - geliceksans;
                    if (random1 >= gecersayi)
                    {
                        Console.ForegroundColor = System.ConsoleColor.Green;
                       // Console.BackgroundColor = System.ConsoleColor.White;
                        Console.WriteLine("{0}.denemede gecti, uretilen sayi: {1}  --- sansiniz: {2}", sayac, random1,geliceksans);
                        dondur = false;

                    }
                    else
                    {
                        sayac++;
                        Console.ForegroundColor = System.ConsoleColor.Red;
                     //   Console.BackgroundColor = System.ConsoleColor.Gray;
                        Console.WriteLine("basarısız! {0}.deneme uretilen sayi: {1}  --- sansiniz: {2}", sayac, random1,geliceksans);
                      
                    }

                }
           //     Console.BackgroundColor = System.ConsoleColor.Black;
                Console.ForegroundColor = System.ConsoleColor.White;
                Console.WriteLine("bitti :) tekrar oynamak icin bir tusa basınız");
                string tekrarla = Console.ReadLine();
                if (tekrarla=="")
                {
                    tekrarlaa = true;
                }
            }
            else if (deger1 == "2")
            {
                bool dondur = true;
                int sayac = 0;
                Console.WriteLine("bir sonraki yükseltme için bir tusa basınız");

                Random random = new Random();
                while (dondur == true)
                {
                    Console.ReadLine();
                    int random1 = random.Next(0, 101);
                    int gecersayi = 100 - geliceksans;
                    if (random1 >= gecersayi)
                    {
                        Console.ForegroundColor = System.ConsoleColor.Green;
                        // Console.BackgroundColor = System.ConsoleColor.White;
                        Console.WriteLine("{0}.denemede gecti, uretilen sayi: {1}  --- sansiniz: {2}", sayac, random1, geliceksans);
                        dondur = false;

                    }
                    else
                    {
                        sayac++;
                        Console.ForegroundColor = System.ConsoleColor.Red;
                        //   Console.BackgroundColor = System.ConsoleColor.Gray;
                        Console.WriteLine("basarısız! {0}.deneme uretilen sayi: {1}  --- sansiniz: {2}", sayac, random1, geliceksans);

                    }

                }
                //     Console.BackgroundColor = System.ConsoleColor.Black;
                Console.ForegroundColor = System.ConsoleColor.White;
                Console.WriteLine("bitti :) tekrar oynamak icin bir tusa basınız");
                string ddd = Console.ReadLine();
                if (ddd=="")
                {
                    tekrarlaa = true;
                }
            }
        }
        static void Main(string[] args)
        {
            Basla:
            bool tekrarla = true;
              Console.WriteLine("% Kaç şans istersin? 10 - 20 - 30 - 40 - 50 - 60 - 70 - 80 - 90");
                int geliceksans = int.Parse(Console.ReadLine());
                for (int i = 0; i < 100; i+=10)
                {
                    if (tekrarla == true)
                    {
                        if (geliceksans != i || geliceksans == 0)
                        {
                        }
                        else
                        {
                            tekrarla = false;
                        }
                    }
                }
                if (tekrarla==true)
                {
                   
                    Console.WriteLine("sayi gecersiz, en yakın sayıya yuvarlanıyor");
                    if (geliceksans > 90)
                    {
                        geliceksans = 90;
                    }
                    else
                    {
                        bool lp = true;
                        for (int i = 0; i <= 90; i += 10)
                        {
                            if (lp == true)
                            {
                                if (geliceksans < i)
                                {
                                    geliceksans = i;
                                    lp = false;
                                }
                            }

                        }
                    }
                    
                    Oyna(geliceksans);
                }
                else
                {
                    Oyna(geliceksans);
                    
                }
                if (tekrarlaa==true)
                {
                  Console.Clear();
                    geliceksans = 0;
                    goto Basla;
                }
                Console.ReadKey();  

        }
            
            
       
    }
}
