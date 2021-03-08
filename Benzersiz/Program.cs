using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benzersiz
{
    class Program    
     
    { 

        static int[] sayiEkle(int[] rastgelesayilar)

        {

            Random r = new Random();

            int rsayi;

            for (int i = 0; i < rastgelesayilar.Length; i++)

            {

                rsayi = r.Next(100);

                Console.WriteLine(rsayi);

               rastgelesayilar[i] = rsayi;

            }

            return rastgelesayilar;

        }

        static int[] diziSirala(int[] rastgelesayilar)

        {

            int gecici;

            for (int i = 0; i < rastgelesayilar.Length; i++)

            {

                for (int j = 0; j < rastgelesayilar.Length; j++)

                {

                    if (rastgelesayilar[i] > rastgelesayilar[j])

                    {

                        gecici = rastgelesayilar[i];

                        rastgelesayilar[i] = rastgelesayilar[j];

                        rastgelesayilar[j] = gecici;

                    }

                }

            }

            return rastgelesayilar;

        }

        static void Main(string[] args)

        {

            int[] sayilar = new int[10];

            Console.WriteLine("Rastgele üretilen Sayılar");

            Console.WriteLine("-------------------------");

            sayilar = sayiEkle(sayilar);

            sayilar = diziSirala(sayilar);

            Console.WriteLine("küçükten büyüğe sıralanmış hali");

            Console.WriteLine("--------------------------------");

            for (int i = 0; i < sayilar.Length; i++)

            {

                Console.WriteLine(sayilar[i]);

            }

            Console.ReadKey();

        }
    }
}


