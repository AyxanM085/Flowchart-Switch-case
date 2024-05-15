namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                {
                    Console.Write("147 ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    int count = 0;
                    while (n != 0)
                    {
                        count++;
                        n /= 10;
                    }

                    Console.WriteLine("147 " + count);
                }
            }
        }
    }

}
    

