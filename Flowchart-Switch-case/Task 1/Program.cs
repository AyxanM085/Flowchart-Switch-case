using System.Threading.Channels;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int num = 47;
            bool flag = false;
            if (num == 0 || num == 1)
            {
                Console.WriteLine("Neither prime , nor composite");
            }

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    flag = true;
                }

            }
            if (flag)
            {
                Console.WriteLine("Composite");
            }
            else
            {
                Console.WriteLine("Prime");
            }
        }
    }
}

    
       











