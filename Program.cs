namespace Pratice_InterfacAndIEnumerable_StephanieLopez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SchoolClass prog124 = new SchoolClass("Prog124");

            // Displays student information using foreach!
            foreach (Student student in prog124)
            {
                Console.WriteLine(student);
            }

            Console.ReadKey();
        }
    }
}