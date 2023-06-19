namespace InterfacesIEnumerablePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SchoolClass roster = new SchoolClass();

            foreach(Student item in roster)
            {
                Console.WriteLine(item);
            }
        }
    }
}