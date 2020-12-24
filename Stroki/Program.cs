using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stroki
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Лето - это то самое время года , когда каждому хочется отдохнуть , прибегая к любым видам деятельности и развлечений"; //Написал ,что в голову пришло , не указано как должна выглядеть строка
            Console.WriteLine(s1);
            Console.WriteLine(s1.Substring(0,66));
            Console.WriteLine(s1.Substring(0, 33));
            Console.ReadKey();
        }
    }
}
