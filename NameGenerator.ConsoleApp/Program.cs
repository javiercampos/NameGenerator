using System;
using NameGenerator.En;
using NameGenerator.Es;
using NameGenerator.Sv;

namespace NameGenerator.ConsoleApp
{
    class Program
    {
        static void OutputFullNames<T>(int iterations = 100)
        where T : IRandomNameGenerator, new()
        {
            var nameGen = new T();
            Console.WriteLine($"==== {typeof(T).Name} ==============");
            for (var i = 0; i < iterations; i++)
            {
                Console.Write(nameGen.GetFullName());
                if(i < iterations - 1) Console.Write(", ");
            }

            Console.WriteLine(Environment.NewLine);
        }


        static void Main(string[] args)
        {
            OutputFullNames<SpanishNameGenerator>();
            OutputFullNames<EnglishNameGenerator>();
            OutputFullNames<SwedishNameGenerator>();
        }
    }
}
