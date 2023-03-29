using System;
using System.IO;

namespace gsdc
{
    public static class StringExtensions
    {
        public static bool IsNullOrWhitespace(this string value) => string.IsNullOrWhiteSpace(value);
    }


    class Program
    {
        static void Main(string[] args)
        {
            var config = AppConfiguration.GetConfiguration();
            var message = string.Empty;

            if (config.Value1.IsNullOrWhitespace())
                message += "Value1 is not specified in appsettings.json\n";


            if (config.Value2.IsNullOrWhitespace())
                message += "Value2 is not specified in appsettings.json\n";


            if (config.Value3.IsNullOrWhitespace())
                message += "Value3 is not specified in appsettings.json\n";

            Console.Write(message);
            Console.WriteLine("Exit to close");

            var entry = Console.ReadLine();
            while (entry.ToUpper() != "EXIT")
            {
                entry = Console.ReadLine();
            }
        }
    }
}