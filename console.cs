using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerisini_getir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kontrol edilecek ismi giriniz : ");
            string veri = Console.ReadLine();

            string[] dizi = { "mehmet", "ali", "ayşe", "mubarek" };
            string[] dizi2 = new string[dizi.Length];

            foreach (var item in dizi)
            {
                if (veri == item)
                {
                    Console.WriteLine("sistemde kayılısınız");
                    break;
                }
                else Console.WriteLine();
            }
            Console.WriteLine("elimde bu var".ToUpper());
            foreach (var item in dizi)
            {
                if (veri[0] == item[0] || veri[1] == item[1])
                {
                    Console.WriteLine(item);
                    break;
                }
                else
                {
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
