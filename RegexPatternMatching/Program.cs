
namespace RegexPatternMatching
{
    public class Program
    {
        static void Main(string[] args)
        {
            //UC1
            //FirstNameRegex pattern = new FirstNameRegex();
            //Console.WriteLine(pattern.validateFirstName("Aks"));
			
			//UC2
            LastNameRegex pattern2 = new LastNameRegex();
            Console.WriteLine(pattern2.validateLastName("KOKITKAR"));

        }
    }
}