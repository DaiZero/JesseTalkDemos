using System;
using Microsoft.Extensions.Configuration;

namespace JsonConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder().AddJsonFile("class.json");
            var conf = builder.Build();
            Console.WriteLine($"班级:{conf["ClassName"]}");
            Console.WriteLine($"学生:{conf["Students:0:Name"]}");
        }
    }
}
