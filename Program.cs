namespace ConsoleApp4228
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int count = 0;
            //for (int x = 10; x < 99; x++)
            //{
            //    if (x % 2 == 0)
            //    {

            //        Console.WriteLine(x);
            //        count++;
            //    }
            //}
            //Console.WriteLine($"count= {count}");


            int summ = 0;
            for (int x = 10; x <= 99; x++)
            {
                if (x % 25 == 0)
                {
                    summ += x;
                }

            }
            Console.WriteLine($"{summ}");
            Console.Read();
                    
        }
    }
}