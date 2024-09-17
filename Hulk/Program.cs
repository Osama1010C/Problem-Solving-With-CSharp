namespace Hulk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] msg = { "I hate it ", "I love it ", "I hate that ", "I love that " };
            bool flag = false;
            while (n-- > 0)
            {
                if (!flag)
                {
                    if(n != 0) Console.Write(msg[2]);
                    else Console.Write(msg[0]);
                    flag = true;
                }
                else
                {
                    if (n != 0) Console.Write(msg[3]);
                    else Console.Write(msg[1]);
                    flag = false;
                }
            }
        }
    }
}
