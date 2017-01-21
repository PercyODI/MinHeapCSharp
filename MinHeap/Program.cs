using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinHeap
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randNumGen = new Random();
            Tree tree = new Tree();

            for(int i = 0; i < 10; i++)
            {
                int nextNum = randNumGen.Next(0, 100);
                tree.insert(nextNum);

                Console.WriteLine(nextNum);
            }

            Console.WriteLine("-------------------------------------------");
            tree.printTree();
            Console.ReadLine();
        }
    }
}
