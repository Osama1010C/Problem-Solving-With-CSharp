namespace I_Wanna_Be_the_Guy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string littleX = Console.ReadLine();
            string littleY = Console.ReadLine();
            string[] x = littleX.Split(' ');
            string[] newX = x[1..];
            string[] y = littleY.Split(' ');
            string[] newY = y[1..];


            int[] elements = new int[n];
            for (int i = 0; i < n ; i++) elements[i] = i+1;

            bool[] elementsExist = new bool[n];
            for (int i = 0; i < n; i++) elementsExist[i] = false;

            for(int i = 0;i < newX.Length; i++)
            {
                int num = int.Parse(newX[i]);
                if (IsExist(num, elements))
                {
                    int index = Array.IndexOf(elements, num);
                    elementsExist[index] = true;
                }
            }

            for (int i = 0; i < newY.Length; i++)
            {
                int num = int.Parse(newY[i]);
                if (IsExist(num, elements)) 
                {
                    int index = Array.IndexOf(elements, num);
                    elementsExist[index] = true; 
                }
            }

            bool flag = true;
            foreach (bool i in elementsExist)
            {
                if (!i)
                {
                    flag = false; break;
                }
            }
            if (flag) Console.WriteLine("I become the guy.");
            else Console.WriteLine("Oh, my keyboard!");

        }
        static bool IsExist(int x, int[] arr)
        {
            foreach (int i in arr)
            {
                if(i == x) return true; 
            }
            return false;
        }

        
    }
}
