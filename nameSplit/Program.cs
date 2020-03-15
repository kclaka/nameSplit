using System;

namespace nameSplit 
{ 

   

    class Program
    {

    static void splitName(string name, out string firstNames, out string lastName)
    {
        int i = name.LastIndexOf(' ');
        firstNames = name.Substring(0, i);
        lastName = name.Substring(i + 1);
    }
    static void Main(string[] args)
        {
        
        splitName("Van Hugh Das", out string first, out string last);
            Console.WriteLine(first);
            Console.WriteLine(last);
        }
    }
}
