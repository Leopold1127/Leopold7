using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonuYapma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BASADON:
            Console.WriteLine("Aşağıdan Bir Film Seçiniz!");
            
            var film1 = "Aykut Enişte";
            var film2 = "Bilinmeyen Bir Kadının Mektubu";
            var film3 = "Iron Man";
            var film4 = "Naim";
            var film5 = "Yeşil Yol";
            
            Console.WriteLine( );
            
            Console.WriteLine(film1);
            Console.WriteLine(film2);
            Console.WriteLine(film3);
            Console.WriteLine(film4);
            Console.WriteLine(film5);

            Console.WriteLine( );

            string tus = Convert.ToString(Console.ReadKey().Key);
            if (tus == "A")
            {
                Console.WriteLine("-Seçtiğiniz film" + " " + film1);
            }
            else if (tus == "B")
            {
                Console.WriteLine("-Seçtiğiniz film" + " " + film2);
            }
            else if (tus == "I")
            {
                Console.WriteLine("-Seçtiğiniz film" + " " + film3);
            }
            else if (tus== "N")
            {
                Console.WriteLine("-Seçtiğiniz film" + " " + film4);
            } 
            else if(tus== "Y")
            {
                Console.WriteLine("-Seçtiğiniz film" + " " + film5);
                
            }
            else
            {
                goto BASADON;
            } 
                
            Console.WriteLine( );
            Console.WriteLine( );

            BASADON2:
            Console.WriteLine("Bir menü seçiniz!");
             
            Console.WriteLine( );

            var KolaVeMısır = "Normal Menü";
            var KolaMısırVePatates = "Double Menü";
            var KolaMısırPatatesVeSoğanHalkası = "Mega Menü";
            var KolaMısırPatatesSoğanHalkasıVeBisküvi = "Ultra Menü";


            Console.WriteLine(KolaVeMısır);
            Console.WriteLine(KolaMısırVePatates);
            Console.WriteLine(KolaMısırPatatesVeSoğanHalkası);
            Console.WriteLine(KolaMısırPatatesSoğanHalkasıVeBisküvi);

            Console.WriteLine( );
            string tus2 = Convert.ToString(Console.ReadKey().Key);
            if (tus2 == "N")
            {
                Console.WriteLine("-Seçtiğiniz Menü" + " " + KolaVeMısır);
            }
            else if (tus2 == "D")
            {
                Console.WriteLine("-Seçtiğiniz Menü" + " " + KolaMısırVePatates);
            }
            else if (tus2 == "M")
            {
                Console.WriteLine("-Seçtiğiniz Menü" + " " + KolaMısırPatatesVeSoğanHalkası );
            }
            else if (tus2 == "U")
            {
                Console.WriteLine("-Seçtiğiniz Menü" + " " + KolaMısırPatatesSoğanHalkasıVeBisküvi);
            }
            else
            {
                goto BASADON2;

            }
            
            Console.WriteLine( );
            Console.WriteLine( );

            string koltuk;

            Console.WriteLine("Bir Koltuk Seçiniz!");
            
            koltuk = Console.ReadLine();

            Console.WriteLine("Seçtiğiniz Koltuk {0}",koltuk);

            Console.WriteLine( );
            Console.WriteLine( );
            Console.WriteLine("Seçeneklerinizi Kontrol Ediniz!!!");


            if (tus == "A")
            {
                Console.WriteLine("-Seçtiğiniz film" + " " + film1);
            }
            else if (tus == "B")
            {
                Console.WriteLine("-Seçtiğiniz film" + " " + film2);
            }
            else if (tus == "I")
            {
                Console.WriteLine("-Seçtiğiniz film" + " " + film3);
            }
            else if (tus == "N")
            {
                Console.WriteLine("-Seçtiğiniz film" + " " + film4);
            }
            else if (tus == "Y")
            {
                Console.WriteLine("-Seçtiğiniz film" + " " + film5);

            }

            if (tus2 == "N")
            {
                Console.WriteLine("-Seçtiğiniz Menü" + " " + KolaVeMısır);
            }
            else if (tus2 == "D")
            {
                Console.WriteLine("-Seçtiğiniz Menü" + " " + KolaMısırVePatates);
            }
            else if (tus2 == "M")
            {
                Console.WriteLine("-Seçtiğiniz Menü" + " " + KolaMısırPatatesVeSoğanHalkası);
            }
            else if (tus2 == "U")
            {
                Console.WriteLine("-Seçtiğiniz Menü" + " " + KolaMısırPatatesSoğanHalkasıVeBisküvi);
            }

            Console.WriteLine("-Seçtiğiniz koltuk" + " " + koltuk);






            Console.ReadLine();





        }
    }
}
