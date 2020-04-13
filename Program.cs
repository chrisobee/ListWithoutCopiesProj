using System;

namespace CopyListWithoutDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            ListWithoutCopies newList = new ListWithoutCopies();
            var list = newList.RemoveDuplicates();
            foreach(string name in list)
            {
                Console.WriteLine(name);
            }
        }
    }
}
