using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._01._2024_classörnek_
{
    internal class Metod
    {

        public int Toplam(int[] sayiDizisi)
        {
            int toplam  = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
            }
            return toplam;
        }
      
    }
}
