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

            for(int i = 0; i < 25; i++)
            {
                int nextNum = randNumGen.Next(0, 100);
                tree.insert(nextNum);

                Console.WriteLine(nextNum);
            }

            Console.WriteLine("-------------------------------------------");
            tree.printTree();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Removing: " + tree.extractMin().getValue());
                Console.WriteLine("-------------------------------------------");
                tree.printTree();
            }

            Console.ReadLine();
        }
    }
}
