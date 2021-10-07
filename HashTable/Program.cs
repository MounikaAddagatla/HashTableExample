using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");

            string hash2 = hash.GetV("3");
            Console.WriteLine(hash2);
            Console.ReadLine();
        }
    }
}
