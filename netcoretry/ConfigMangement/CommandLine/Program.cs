using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace CommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
            var setting = new Dictionary<string, string>() {
                {"name","zero" },
                {"age","13" }
            };

            var builder = new ConfigurationBuilder()
                .AddInMemoryCollection(setting)
                .AddCommandLine(args);
            var conf = builder.Build();
            Console.WriteLine(conf["name"]);
            Console.WriteLine(conf["age"]);
        }
    }
}
