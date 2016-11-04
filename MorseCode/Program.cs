using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            MorseCodeDecoder decoder = new MorseCodeDecoder();
            Console.WriteLine("Decoder");
            //List<String> ret = decoder.decode(".");
            List<String> ret = decoder.decode(".-");
            Console.WriteLine(String.Join(" ", ret));
        }
    }
}
