using System;

namespace LeastRecentlyUsedAlgorithm_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Least Recently Used Algorithm - Cache implementation!");
            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("Enter the size of the cache memory");
            try
            {
                int sizeOfDLL = int.Parse(Console.ReadLine());
                LRUCache lRUCache = new LRUCache(sizeOfDLL);
                int choice = 0;
                do {
                    Console.WriteLine("Enter the element you would like to refer" +
                        " in the cache");
                    int element = int.Parse(Console.ReadLine());
                    lRUCache.ReferPageInLRUCache(element);
                    Console.WriteLine();
                    lRUCache.PrintCacheElements(lRUCache.GetLRUCacheDoublyLinkedList());
                    Console.WriteLine("If you want to continue referring the cache," +
                        " press 0");
                    choice = int.Parse(Console.ReadLine());
                } while (choice == 0);
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+
                    exception.Message);
            }

            Console.ReadLine();
        }
    }
}
