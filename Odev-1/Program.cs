using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13253013HW1
{
    class Program
    {
        static void Main()
        {
            hesaplamalar hesapSonuc = new hesaplamalar(); ////clasın objesini olusturduk.
            /// tanımlamalar.....
            char c;
            string secim;
            string ıslem = null;
            string sayi1, sayi2;
            float x, y;

            Console.Write("Birinci Sayiyi Giriniz:");
            sayi1 = Console.ReadLine();
            bool sonuc1 = float.TryParse(sayi1, out x);
            if (sonuc1) ///1.sayı dogruysa ....
            {

                Console.Write("Bİr Islem Giriniz[+,-,*,/]:");
                ıslem = Console.ReadLine();
                bool sonucIslem = char.TryParse(ıslem, out c);
                if (sonucIslem)
                {
                    Console.Write("ikini sayıyı giriniz:");
                    sayi2 = Console.ReadLine();
                    bool sonuc2 = float.TryParse(sayi2, out y);
                    if (sonuc2)
                    {
                        if (ıslem == "+")
                        {
                            Console.WriteLine("Sonuc={0}", hesapSonuc.toplama(x, y));


                        }
                        else if (ıslem == "-")
                        {
                            Console.WriteLine("Sonuc={0}", hesapSonuc.cıkarma(x, y));
                        }
                        else if (ıslem == "*")
                        {
                            Console.WriteLine("Sonuc={0}", hesapSonuc.carpma(x, y));

                        }
                        else if (ıslem == "/")
                        {
                            Console.WriteLine("Sonuc={0}", hesapSonuc.bolme(x, y));

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Girilen Islem Hatalı:");
                            Console.ResetColor();
                        }

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red; ///hata mesajını renkli yazdırma......
                        Console.WriteLine("İkinci Sayıyı yanlıs girdiniz:");
                        Console.ResetColor();////rengi sıfırlama.............................
                        Main();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Yanlıs Bir Islem  Girdiniz:");
                    Console.ResetColor();

                    Main();
                }


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Birinci Sayıyı Yanlıs Girdiniz:");
                Console.ResetColor();
                Main();
            }
            ///kullanıcının devam edip etmeyecegi soruluyor .............
            do
            {
                Console.WriteLine("Devam etmek İstiyormusunuz(e)(h):");
                secim = Convert.ToString(Console.ReadLine());

                if (secim == "e" || secim == "E")
                {
                    Main();
                }
                else if (secim == "h" || secim == "H")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Devam Etmek İcin E/e Girin:\nCıkmak İcin H/h  Girin:");
                    Console.ResetColor();

                }
            } while (secim != "e" || secim != "h");


        }
    }
}
