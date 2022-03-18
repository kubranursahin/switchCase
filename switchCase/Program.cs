using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swicthCase
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 1-12 arasında değer giriniz :");
            int sayi = Convert.ToInt32(Console.ReadLine());
            switch (sayi)
            {
                case 1:
                    Console.WriteLine("OCAK");
                    break;
                case 2:
                    Console.WriteLine("ŞUBAT");
                    break;
                case 3:
                    Console.WriteLine(" MART");
                    break;
                case 4:
                    Console.WriteLine("NİSAN");
                    break;
                case 5:
                    Console.WriteLine("MAYIS");
                    break;
                case 6:
                    Console.WriteLine("HAZİRAN");
                    break;
                case 7:
                    Console.WriteLine("TEMMUZ");
                    break;
                case 8:
                    Console.WriteLine("AĞUSTOS");
                    break;
                case 9:
                    Console.WriteLine("EYLÜL");
                    break;
                case 10:
                    Console.WriteLine("EKİM");
                    break;
                case 11:
                    Console.WriteLine("KASIM");
                    break;
                case 12:
                    Console.WriteLine("ARALIK");
                    break;
                default:
                    Console.WriteLine("Lütfen geçerli bir değer giriniz! :)");
                    break;
            }
             Console.ReadLine();
        }
    }
}
