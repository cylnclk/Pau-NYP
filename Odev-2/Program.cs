using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Boyutu girin:");  ///kullanıcıdan boyutu ve komutu aldık
            dizi Objem = new dizi( int.Parse(Console.ReadLine()));
            string gelenKomut; 
            Console.WriteLine("Komut girin:");
            gelenKomut = Console.ReadLine();
            int gelenYon,sayac =0;
           
            string[] parcalanmıs_Komut = gelenKomut.Split('+');  ///komutu + ya göre parcaladık
            for (int i = 0; i < parcalanmıs_Komut.Length; i++)
            {
                if (parcalanmıs_Komut[i].Contains("_"))  ///gelen komutta kac defa _ var..
                {
                    sayac++;
                }
            }
            int[] diziX = new int[sayac];
            int k = 0;
            gelenYon = Objem.yonumuBul("3");  ///default yönume gidecek komut ....
            for (int i = 0; i < parcalanmıs_Komut.Length; i++)
            {
                if (parcalanmıs_Komut[i].Contains("_"))
                {
                    diziX[k++] = int.Parse(parcalanmıs_Komut[i].Substring(2));
                }
            }
          
            int sayacX = 0;
            for (int i = 0; i < parcalanmıs_Komut.Length; i++)
            {
                if (parcalanmıs_Komut[i].Contains("_"))
                {
                    
                    if (gelenYon == 44)   /////artı x yonunde ilerleme metodunu cagırdık....
                    {
                        Objem.artiXYonundeilerde(diziX[sayacX]);
                        Objem.arabakonum[1] += diziX[sayacX++];
                       
                    } else
                     if (gelenYon == 33)  /////eksi y yonunde ilerleme metodunu cagırdık....
                    {
                        Objem.eksiYyonunde(diziX[sayacX]);
                        Objem.arabakonum[0] -= diziX[sayacX++];
                        
                    } 
                    else
                    if (gelenYon==77)  /////ari y yönünde ilerleme metodu....
                    {
                        Objem.artiYyonunde(diziX[sayacX]);
                        Objem.arabakonum[0] += diziX[sayacX++];
                      
                    } else
                    if (gelenYon==88)
                    {
                        Objem.eksiXyonundeilerle(diziX[sayacX]);
                        Objem.arabakonum[1] -= diziX[sayacX++];
                       
                    }

                }

                if (parcalanmıs_Komut[i] == "3")
                {
                    Objem.yon  = gelenYon;
                    gelenYon = Objem.yonumuBul("3");
                    
                }
                if (parcalanmıs_Komut[i] == "4")
                {
                    Objem.yon = gelenYon;
                    gelenYon = Objem.yonumuBul("4");
                    
                }
                if (parcalanmıs_Komut[i] == "7")
                {
                    Objem.yon = gelenYon;
                    gelenYon = Objem.yonumuBul("7");
                }
                 if (parcalanmıs_Komut[i] == "1")
                {
                    Objem.fırcaDurumu = 1; ///fırca 1 durumunda olacak
                }
                if (parcalanmıs_Komut[i] == "6")///// gelen yöne göre zıplama metodlarım cagırdık...
                {
               
                 if (gelenYon==44)
                 {
                     Objem.artiXZiPLA();
                 }
                 else if (gelenYon==33)
                 {
                     Objem.eksiYZipla();
                 }
                 else if (gelenYon==77)
                 {
                     Objem.artiYZipla();
                 }
                 else if (gelenYon==88)
                 {
                     Objem.eksixZipla();
                 }

                   
                }
                if (parcalanmıs_Komut[i] == "2")//2 oldugunda fırca yukarda olacak..
                {
                    Objem.fırcaDurumu = 2;  
                }
                if (parcalanmıs_Komut[i] == "8")  ///matrisi görüntüleyen metodu cagırdık.
                {
                    Objem.diziGoruntule();
                }
                if (parcalanmıs_Komut[i] == "0") // Console.WriteLine("Sıfırı gordu program bitti");
                {
                  
                    Environment.Exit(0);
                }
               
                    
                }
            }
            
          }
        }
