using System;

class Program
{
    static void Main()

        
    {
        //2

        /*  Console.WriteLine("Həndəsi Kalkulyator");
          Console.WriteLine("1. Dairə");
          Console.WriteLine("2. Düzbucaqlı");
          Console.WriteLine("3. Üçbucaq");
          Console.Write("Fiqur seçin: ");

          int secim = Convert.ToInt32(Console.ReadLine());

          double sahe = 0;

          switch (secim)
          {
              case 1:
                  Console.Write("Radiusu daxil edin: ");
                  double radius = Convert.ToDouble(Console.ReadLine());

                  sahe = Math.PI * Math.Pow(radius, 2);

                  Console.WriteLine("Dairənin sahəsi: " + Math.Round(sahe, 2));
                  break;

              case 2:
                  Console.Write("Uzunluğu daxil edin: ");
                  double uzunluq = Convert.ToDouble(Console.ReadLine());

                  Console.Write("Eni daxil edin: ");
                  double en = Convert.ToDouble(Console.ReadLine());

                  sahe = uzunluq * en;

                  Console.WriteLine("Düzbucaqlının sahəsi: " + Math.Round(sahe, 2));
                  break;

              case 3:
                  Console.Write("Birinci tərəfi daxil edin: ");
                  double a = Convert.ToDouble(Console.ReadLine());

                  Console.Write("İkinci tərəfi daxil edin: ");
                  double b = Convert.ToDouble(Console.ReadLine());

                  Console.Write("Üçüncü tərəfi daxil edin: ");
                  double c = Convert.ToDouble(Console.ReadLine());

                  double yarimPerimetr = (a + b + c) / 2;

                  sahe = Math.Sqrt(
                      yarimPerimetr *
                      (yarimPerimetr - a) *
                      (yarimPerimetr - b) *
                      (yarimPerimetr - c)
                  );

                  Console.WriteLine("Üçbucağın sahəsi: " + Math.Round(sahe, 2));
                  break;

              default:
                  Console.WriteLine("Yanlış seçim etdiniz.");
                  break;
          }*/





        //3

        /*
         List<int> ededler = new List<int>();

         for (int i = 0; i < 10; i++)
         {
             Console.Write((i + 1) + ". ədədi daxil edin: ");
             int eded = Convert.ToInt32(Console.ReadLine());

             ededler.Add(eded);
         }

         int enBoyuk = ededler[0];
         int enKicik = ededler[0];

         int cutSay = 0;
         int tekSay = 0;

         foreach (int eded in ededler)
         {
             if (eded > enBoyuk)
             {
                 enBoyuk = eded;
             }

             if (eded < enKicik)
             {
                 enKicik = eded;
             }

             if (eded % 2 == 0)
             {
                 cutSay++;
             }
             else
             {
                 tekSay++;
             }
         }

         Console.WriteLine("\nƏn böyük ədəd: " + enBoyuk);
         Console.WriteLine("Ən kiçik ədəd: " + enKicik);
         Console.WriteLine("Cüt ədədlərin sayı: " + cutSay);
         Console.WriteLine("Tək ədədlərin sayı: " + tekSay);
         */






        //4

        /*
            Random random = new Random();

        int gizliEded = random.Next(0, 101);
        int texmin;

        do
        {
            Console.Write("0-100 arası bir ədəd daxil edin: ");
            texmin = Convert.ToInt32(Console.ReadLine());

            if (texmin > gizliEded)
            {
                Console.WriteLine("Daha kiçik ədəd cəhd edin.");
            }
            else if (texmin < gizliEded)
            {
                Console.WriteLine("Daha böyük ədəd cəhd edin.");
            }
            else
            {
                Console.WriteLine("Təbriklər!");
            }

        } while (texmin != gizliEded);         */
    }
}
