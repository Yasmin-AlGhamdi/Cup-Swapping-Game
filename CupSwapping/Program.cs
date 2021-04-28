using System;

namespace CupSwapping
{
    class Program
    {
        public static string cupSwapping(string[] swaps)
        {
            string current = "B";
            for(int i = 0; i < swaps.Length; i++)
            {
                if(swaps[i].Contains(current))
                {
                    current = swaps[i].Replace(current, "");
                }

            }
            
            return current;
        }
        static void Main(string[] args)
        {
            string[] swaps = new string[] {"CB","AC","CA"};
            Console.WriteLine(cupSwapping(swaps));


            Console.ReadKey();
        }
    }
}
