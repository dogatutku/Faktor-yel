using System;

namespace FaktoriyelÖdev
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı , i;
            Console.WriteLine("Lütfen Faktoriyeli Hesaplanacak Sayıyı Giriniz:");
            sayı = Convert.ToInt32(Console.ReadLine());
            for ( i = sayı-1; i > 1; i--)
            {
                sayı = sayı * i;
            }
            Console.WriteLine("İşlem Sonucu :{0}",sayı);
            Console.ReadLine();
        }
    }
}
