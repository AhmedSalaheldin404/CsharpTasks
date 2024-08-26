using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

namespace iti
{
    internal class Program
    {
        static int PowerRecursive(int baseNum, int power)
        {
            if (power == 0)
            {
                return 1;
            }
            else
            {
                int sol =  baseNum * PowerRecursive(baseNum, power - 1);
                return sol;
            }
        }

        // Example usage
        static void Main()
        {
            Console.WriteLine(PowerRecursive(3, 2));  // Output: 9
            Console.WriteLine(PowerRecursive(5, 2));  // Output: 25
        }
    }
}
