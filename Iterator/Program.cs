using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var linkedList = new LinkedList<int>() { 1, 5, 4, 7, 2 };
            foreach (int num in linkedList)
            {
                Console.WriteLine(num);
            }
        }
    }
}