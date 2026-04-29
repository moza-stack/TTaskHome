using System.Linq.Expressions;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Dictionary<string, int> studentData = new Dictionary<string, int>();
            studentData.Add("Ali", 25);
            studentData.Add("Moza", 27);
            try
            {
                Console.WriteLine($"Ali is " + studentData["Ali"] + "years old"); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
