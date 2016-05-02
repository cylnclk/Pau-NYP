using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _HW2
{
    class dizi
    {
        public  int fırcaDurumu;  ///fırcanın durumu
        public  string a,sag;
        public  int b;
       int[,] matris;
       public int[] arabakonum=new int [] {0,0}; //// arabanın ilk konumu
       public  int[] yonler = new int[] { 33, 44, 77, 88 };
        /// 33 EKSİ Y
        /// 44 ARTI X
        /// 77 ARTI Y
        /// 88 EKSİ X,
        public int yon;
       
        public dizi()  /// CONSTRUCTIRI  
        {
            yon = 33; ///yon ilk basta -y de..
            fırcaDurumu = 2;
           // sag = "3";
        }

        public dizi(int sayi)
        {
            yon = 33; ///yon ilk basta -y de..
            fırcaDurumu = 2; ///fırca ilk basta yukarda....
            this.b = sayi;
            matris = new int[b, b];
        }
       
        public void diziGoruntule() /////diziyi görüntüleyen method ......
        {
         
            for (int i = 0; i <b; i++) ////satır 
            {
                for (int j = 0; j <b; j++) ///sutun
                {
                    Console.Write(matris[i, j] + "|");
                }
                Console.WriteLine();
            }

        }

        public int yonumuBul(string komutdizisi)  ////yon bulan metod.....
        {
            
            if (yon == 33) ////eksi yyyyy
            {
                if (komutdizisi== "3")
                    {
                        return yonler[1];
                    }
                    else if (komutdizisi == "4")
                    {
                        return yonler[3];
                    
                    }
                    else if (komutdizisi=="7")
                    {
                        return yonler[2];
                    }
                
            }
            else if ( yon ==77) ///ARTI Y YONUM
            {
                
                    if (komutdizisi=="3")
                    {
                        return yonler[3];
                        
                    }
                    else if(komutdizisi=="4")
                    {
                        return yonler[2];
                    }
                    else if (komutdizisi=="7")
                    {
                        return yonler[0];
                    }
                    
            }
            else if (yon== 88)  /////////EKSİ X
            {
               
                    if (komutdizisi=="3")
                    {
                       return  yonler[0];
                    }
                    else if (komutdizisi=="4")
                    {
                        return yonler[2];
                    }
                    else if (komutdizisi=="7")
                    {
                        return yonler[1];
                    }
                    
                    
              
            }
            else
            if (yon== 44) ////artı x
            {
               
                    if (komutdizisi == "3")
                    {
                        return yonler[2];

                    }
                    else if (komutdizisi == "4")
                    {
                        return yonler[0];
                    }
                    else if (komutdizisi== "7")
                    {
                        return yonler[3];

                    }
                  
              
                
            }

            return -1;
        }   

        public void artiXYonundeilerde(int x)
        {
           ///boyut tasmıyorsa
            int k = arabakonum[1];
            if (k+x<=b-1)
            {
                if (fırcaDurumu == 1)///fırca asagıdaysa..
                {
                    for (int i = arabakonum[1]; i < arabakonum[1] + x; i++)
                    {
                        matris[arabakonum[0], i] = 1;
                    }

                }
                else if (fırcaDurumu == 2) ///fırca yukarıdaysa..
                {
                    for (int i = arabakonum[1]; i < arabakonum[1] + x; i++)
                    {
                        matris[arabakonum[0], i] = 0;
                    }
                }
                
            }
            else
            {
                if (fırcaDurumu==1)
                {
                    for (int i = arabakonum[1]; i < b+arabakonum[1]; i++)
                    {
                        matris[arabakonum[0], i] = 1;
                    }
                    x -= arabakonum[1];
                    arabakonum[1] = 0;
                    for (int i = 0; i < x+ arabakonum[1]; i++)
                    {
                        matris[arabakonum[0],i]=1;
                    }
                }
                else ///fırca yukardaysa
                {
                    for (int i = arabakonum[1]; i < b; i++)
                    {
                        matris[arabakonum[0], arabakonum[1]++] = 0;
                    }
                    x -= arabakonum[1];
                    arabakonum[1] = 0;
                    for (int i = 0; i < x; i++)
                    {
                        matris[arabakonum[0], arabakonum[1]++] = 0;
                    }
                }
            }

        }   ///aartı x de ilerleme

         public void artiYyonunde(int x)
        {
            int k = arabakonum[0];
            if (k+x<=b-1) //tasma yoksa
            {
                if (fırcaDurumu==1)
                {
                    for (int i = arabakonum[0]; i <arabakonum[0]+x; i++)
                    {
                        matris[i, arabakonum[1]] = 1;
                    }
                    
                }
                if (fırcaDurumu==2)
                {
                    
                    for (int i = arabakonum[0]; i <x+arabakonum[0]; i++)
                    {
                        matris[i, arabakonum[1]] = 0;
                    }
                    
                }
            }
            else
            {
                if (fırcaDurumu==1)
                {
                    for (int i = arabakonum[0]; i < b; i++)
                    {
                        matris[arabakonum[0]++,arabakonum[1]]=1;
                    }
                    x = b - 1 - arabakonum[0];
                    arabakonum[0] = 0;
                    for (int i = 0; i < x; i++)
                    {
                        matris[arabakonum[0]++,arabakonum[1]]=1;
                    }
                }
                if (fırcaDurumu==2)
                {
                     for (int i = arabakonum[0]; i < b; i++)
                    {
                        matris[arabakonum[0]++,arabakonum[1]]=0;
                    }
                    x -= arabakonum[0];
                    arabakonum[0] = 0;
                    for (int i = 0; i < x; i++)
                    {
                        matris[arabakonum[0]++,arabakonum[1]]=0;
                    }
                }
            }

        
        }

        public void eksiXyonundeilerle(int x)  
        {
            ///boyut tasmıyorsa 
           
            if (arabakonum[1] - x >= 0)
            {
                if (fırcaDurumu == 1)
                {
                    for (int i = arabakonum[1]; i < x+arabakonum[1]; i++)
                    {
                        matris[arabakonum[0], i] = 1;
                    }
                }
                if (fırcaDurumu == 2)
                {
                    for (int i = arabakonum[1]; i < x; i++)
                    {
                        matris[arabakonum[0], arabakonum[1]--] = 0;
                    }
                }
            }
            else ///tasıyorsa..
            {
                int count = 0;
                int k = arabakonum[1];
                if (fırcaDurumu==1) 
                {
                    for (int i = arabakonum[1]; i >=0; i--)
                    {
                        matris[arabakonum[0],arabakonum[1]--]=1;
                        count++;
                    }
                   
                    arabakonum[1] = b - 1;
                   x =arabakonum[1] -x+1;
                  
                    for (int i = arabakonum[1]; i > x; i--)
                    {
                        matris[arabakonum[0], arabakonum[1]--] = 1;
                    }
                    
                }
                if (fırcaDurumu==2)
                {
                     for (int i = arabakonum[1]; i >= 0; i--)
                    {
                        matris[arabakonum[0],arabakonum[1]--]=0;
                    }
                    x -= arabakonum[1] + 1;
                    arabakonum[1] = b - 1;
                    for (int i = b-1; i > x; i--)
                    {
                        matris[arabakonum[0],arabakonum[1]--]=0;
                    }
                }
            
            }
        }  //

        public void eksiYyonunde(int x)
        {
           //bouyt tasmıyorsa
            int k=arabakonum[0];
            if (arabakonum[0]-x>=0)
            {
                if (fırcaDurumu==1)
                {
                    for (int i = arabakonum[0]; i <x+arabakonum[0]; i--)
                    {
                       matris[i,arabakonum[1]]=1;
                    }
                }
                if (fırcaDurumu==2) //fırca yukardaysa
                {
                     for (int i = arabakonum[0]; i <x+arabakonum[0]; i--)
                    {
                       matris[i,arabakonum[1]]=0;
                    }
                }
            }
            
            else ////tasma oldugu zaman .....
            {
                if (fırcaDurumu==1)
                {
                    for (int i = arabakonum[0]; i >=0; i--)
                    {
                        matris[arabakonum[0]--, arabakonum[1]] = 1;
                    }


                    arabakonum[0] = b - 1;
                    x = arabakonum[0] - x + 1;
                    for (int i = arabakonum[0]; i > x; i--)
                    {
                        matris[arabakonum[0]--,arabakonum[1]]=1;
                    }
                }
                if (fırcaDurumu==2)
                {
                     for (int i = arabakonum[0]; i >=0; i--)
                    {
                        matris[arabakonum[0]--, arabakonum[1]] = 0;
                    }


                    arabakonum[0] = b - 1;
                    x = arabakonum[0] - x + 1;
                    for (int i = arabakonum[0]; i > x; i--)
                    {
                        matris[arabakonum[0]--,arabakonum[1]]=0;
                    }
                }
             
            }
        
        }
          //ZIPLAMA METOTLARI////
        public void artiXZiPLA()   /////artı x yonunde zıpla 
        {
            int x = 3;
            int k = arabakonum[1]; ///aracın ilk konumu..
            
            ///tasma yoksa
            if (arabakonum[1]+x<b)
            {
                for (int i = arabakonum[1]; i <k+3; i++)
                {
                    
                    matris[arabakonum[0],arabakonum[1]++]=0;
                }
            }
            else///tasma varsa
            {
                for (int i = arabakonum[1]; i <= b-1; i++)
                {
                    matris[arabakonum[0],arabakonum[1]++]=0;
                }
               x-= arabakonum[1];
                arabakonum[1] = 0;
                for (int i = arabakonum[1]; i> x; i++)
                {
                    matris[arabakonum[0],arabakonum[1]++]=1;
                }
                
            }
        
        
        }

        public void artiYZipla() ///artı y yonunde zıplama..
        {
            int x = 3;
            int k = arabakonum[0];
            if (arabakonum[0]+x<b)  ///tasma yoksa
            {
                for (int i = k; i < k+x; i++)
                {
                     matris[arabakonum[0]++,arabakonum[1]]=0;
                }
               
            }
            else //tasma varsa
            {
                for (int i = k; i < b; i++)
                {
                    matris[arabakonum[0]++,arabakonum[1]]=0;
                }
                int c = arabakonum[0] % b;
                arabakonum[0] = 0;
                for (int i = 0; i < c; i++)
                {
                    matris[arabakonum[0]++,arabakonum[1]]=0;
                }
            }
        
        }

        public void eksixZipla()
        {  ///sutun azalır..
            int k = arabakonum[1];
            int x = 3;
            if (k-x>=0) ////tasmayoksa...
            {
                for (int i = arabakonum[1]; i > 0; i--)
                {
                    matris[arabakonum[0],arabakonum[1]--]=0;
                }
                
            }
            else
            {
                for (int i = k; i >=0; i--)
                {
                    matris[arabakonum[0],arabakonum[1]--]=0;
                }

                arabakonum[1] = b - 1;
                x = arabakonum[1] - x + 1;
                for (int i = arabakonum[1]; i > x; i--)
                {
                    matris[arabakonum[0],arabakonum[1]--]=0;
                }
            }
        
        } ////ekside X yonunde  zıpla....

        public void eksiYZipla()  ///eksi y yonunde zıpla ....
        {
            int k = arabakonum[0];
            int x = 3;
            ///tasmayoksa
            if (arabakonum[0] - x > 0)
            {
                for (int i = arabakonum[0]; i > x; i--)
                {
                    matris[arabakonum[0]--, arabakonum[1]] = 0;
                }

            }
            else ///tasma oldugu zaman 
            {
                for (int i = k; i >0; i--)
                {
                    matris[arabakonum[0]--,arabakonum[1]]=0;
                }
                arabakonum[0] = b - 1;
                x = arabakonum[0] - x + 1;
                for (int i = arabakonum[0]; i >x; i--)
                {
                    matris[arabakonum[0]--, arabakonum[1]] = 0;
                }
            }
        
        }  
    }
    }

