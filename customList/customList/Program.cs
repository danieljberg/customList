using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customList
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomList<int> customList = new CustomList<int>();
            //customList.Add(5);
            //customList.Add(10);
            //customList.Add(15);
            //customList.Add(20);
            //customList.Add(25);
            //customList.Add(30);
            //customList.Add(35);
            //string stringList = customList.ToString();            
            //Console.WriteLine(stringList);            
            //Console.ReadLine();

            //CustomList<string> customList1 = new CustomList<string>();
            //customList1.Add("Packers");
            //customList1.Add("Bears");
            //customList1.Add("Lions");
            //Console.WriteLine(customList1);
            //Console.ReadLine();
            
            CustomList<int> one = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> two = new CustomList<int>() { 2, 1, 6 };
            CustomList<int> three = one - two;
            Console.WriteLine(three);
            Console.ReadLine();
        }
    }

}
