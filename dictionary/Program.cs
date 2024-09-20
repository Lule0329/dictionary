using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            dict["Paladin"] = 300;
            dict["Druid"] = 150;
            dict["Mage"] = 50;
            dict["Human"] = 100;
            dict["Barbarian"] = 400;

            foreach (var key in dict)
            {
                Console.WriteLine($"{key.Key} har {key.Value} hp");
            }
        }
    }
}
