using System;

namespace TesteNLog
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Logs.Writer();
            Console.WriteLine("Digite seu documento por favor:");
            var document = Console.ReadLine();
            a.WriteInFile(document);
            
        }
    }
}
