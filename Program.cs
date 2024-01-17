using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._01._2024_classörnek_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // kullanıcıdan kaç adet sayı girmek istediğini sorup top ve ort yazdıralım.

            // sayı adedi ve isteme işini Main metodu içerisinde yapabiliriz.
            //Daha sonra oluşturulan diziyi toplam işlemi yapıp sonucu döndürebiliriz.

            Console.Write("Adet giriniz: ");
            int adet=int.Parse(Console.ReadLine());
            int[]sayilar=new int[adet];

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write("{0}. sayıyı giriniz: ",i+1);
                sayilar[i]= int.Parse(Console.ReadLine());
            }
            Metod m=new Metod();
            m.Toplam(sayilar);

            Console.WriteLine("Toplam: " + m.Toplam(sayilar));
            Console.ReadKey();
        }
    }
}
