namespace Anton_and_Polyhedrons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] line = new string[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                line[i] = Console.ReadLine();
                switch (line[i]){
                    case "Tetrahedron": sum+=4; break;
                    case "Cube": sum+=6; break;
                    case "Octahedron": sum+=8; break;
                    case "Dodecahedron": sum+=12; break;
                    case "Icosahedron": sum+=20; break;
                    default:sum+=0; break;
                }
            }
            Console.WriteLine(sum);          
        }
    }
}
