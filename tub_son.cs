using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tub_son
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Son kiriting: ");
            int number = int.Parse(Console.ReadLine());
            int boluvchilar_soni=0;
            for(int i = 1; i <= number;i++)
            {
                if(number%i== 0)
                {
                    boluvchilar_soni++;
                }
            }
            if (boluvchilar_soni == 1)
            {
                Console.WriteLine($"{number}-soni tub son ham va murakkab son ham emas!");
            }else if(boluvchilar_soni==2)
            {
                Console.WriteLine($"{number}-tub son");
            }
            else
            {
                Console.WriteLine($"{number}-tub son emas");
            }
            
            Main(args);
        }
    }
}
