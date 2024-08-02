using System.Text;

namespace Clean_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder inputBuilder = new StringBuilder();
            string line;

            while ((line = Console.ReadLine()) != "}")
            {
                inputBuilder.AppendLine(line);
            }

            string multiLineInput = inputBuilder.ToString();

            // Split the input into an array of lines
            string[] linesArray = multiLineInput.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            List<string> lines = new List<string>();
            for (int i = 0; i < linesArray.Length-1; i++)
            {
                if (string.IsNullOrWhiteSpace(linesArray[i])) continue;

                else if (linesArray[i][0] == '/' && linesArray[i][1] == '/') continue;
                else if (linesArray[i][0] == '/' && linesArray[i][1] == '*') i+= 2;
                else if (IsThereComment(linesArray[i]))
                {
                    linesArray[i] = RemoveComment(linesArray[i]);
                    lines.Add(linesArray[i]);
                }
                else lines.Add(linesArray[i]);
            }
            lines.Add("}");
            
            foreach(string s in lines)
            {
                Console.WriteLine(s);
            }
        }
        public static string RemoveComment(string text)
        {
            string result = "";

            for(int i = 0; i < text.Length; i++)
            {
                if (text[i] == '/' && text[i + 1] == '/') break;
                result += text[i];
            }

            return result;
        } 

        public static bool IsThereComment(string text)
        {
            for(int i = 0; i < text.Length-1; i++)
            {
                if (text[i] == '/' && text[i + 1] == '/') return true;
            }
            return false;
        }
    }
}
