namespace In_Search_of_an_Easy_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            string[] sinputs = s.Split(' ');
            bool isHard = false;
            foreach (string num in sinputs)
            {
                if(num == "1")
                {
                    isHard = true;
                    break;
                }
            }
            Console.WriteLine(isHard ? "HARD":"EASY");
        }
    }
}
