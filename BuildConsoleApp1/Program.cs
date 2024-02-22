using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace BuildConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string output = JsonConvert.SerializeObject(new object[] { });
        }
    }
}
