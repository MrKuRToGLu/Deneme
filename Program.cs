using System;

namespace Deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("LÜTFEN 0-100 ARASINDA BİR NOT GİRİNİZ"); 

            float vize, final, ort = 0;

            string harfnotu = "";


           

            Console.WriteLine("vize notunuzu giriniz");
            vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final notunuzu giriniz");
            final = Convert.ToInt32(Console.ReadLine());
            ort = (float)(vize * 0.4) + (float)(final * 0.6);

            


            harfnotu = "";

            switch (ort)
            {
                
                case float n when n >= 0 && n <= 24:
                    harfnotu = "FF";
                    break;
                case float n when n >= 25 && n <= 49:
                    harfnotu = "DC";
                    break;
                case float n when n >= 50 && n <= 64:
                    harfnotu = "CC";
                    break;
                case float n when n >= 65 && n <= 74:
                    harfnotu= "BB";
                    break;
                case float n when n >= 75 && n <= 84:
                    harfnotu = "BA";
                    break;
                case float n when n >= 85 && n <= 100:
                    harfnotu = "DC";
                    break;
                case float n when n > 100:
                    harfnotu = "GEÇERSİZ";
                    break;

                   


            }
            Console.WriteLine($"Ortalamanız ={ort} HarfNotunuz = {harfnotu}");

            Console.WriteLine("Kapatmak için bir tuşa basınız");




















        }

    }
}