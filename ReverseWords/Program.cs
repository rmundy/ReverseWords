using System.IO;

namespace ReverseWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public sealed class Program
    {
        public static void Main(String[] args)
        {
            using (var fs = File.Open(args[0], FileMode.Open))
            {
                using (var bs = new BufferedStream(fs))
                using (var sr = new StreamReader(bs))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        
                    }
                }
            }

        }
    }
}
