using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._01_rb_acid
{
    class Program
    {
        static string TranslateDNAtoRNA(string dna)
        {
            if (dna.Length == 0)
                return "";

            char[] dnaArray = dna.ToCharArray();

            for (int i = 0; i < dnaArray.Length; i++)
            {
                switch (dnaArray[i])
                {
                    case 'G':
                        dnaArray[i] = 'C';
                        break;
                    case 'C':
                        dnaArray[i] = 'G';
                        break;
                    case 'A':
                        dnaArray[i] = 'U';
                        break;
                    case 'T':
                        dnaArray[i] = 'A';
                        break;
                }
            }

            return new String(dnaArray);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(TranslateDNAtoRNA("GCAT"));
        }
    }
}
