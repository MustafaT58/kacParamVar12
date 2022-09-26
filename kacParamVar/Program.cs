using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kacParamVar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal tlTutar = cevir("Kaç TL Var = ");
            decimal euroTutar = cevir("Kaç EURO Var = ");
            decimal dolarTutar = cevir("Kaç DOLAR Var = ");
            dolarTutar = kurHesapla(dolarTutar, "Dolar Kuru Ne Kadar? = ");
            euroTutar = kurHesapla(euroTutar, "Euro Kuru Ne Kadar? = ");
            decimal toplam = (dolarTutar + euroTutar + tlTutar);
            yazdir(toplam); 
            Console.ReadKey();
        }
        static decimal cevir(string soru)
        {
            try
            {
                Console.Write(soru);
                return Convert.ToDecimal(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("Sayısal Değer Giriniz!!!");
                return 0;
            }
        }
        static decimal kurHesapla(decimal yp, string kurSorusu)
        {
            decimal kur = cevir(kurSorusu);
            return yp * kur;
        }
        static void yazdir(decimal toplam)
        {
            Console.Write("Toplam Değer = "+toplam);
        }
    }
}
