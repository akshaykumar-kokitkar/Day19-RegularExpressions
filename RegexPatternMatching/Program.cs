
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
            //LastNameRegex pattern2 = new LastNameRegex();
            //Console.WriteLine(pattern2.validateLastName("KOKITKAR"));
			
			//UC3
            //EmailRegex pattern3 = new EmailRegex();
            //Console.WriteLine(pattern3.validateEmail("abc.xyz@bl.co.in"));
			
			//UC4
			//MobileNumberRegex pattern4 = new MobileNumberRegex();
            //Console.WriteLine(pattern4.ValidateMobileNo("91 7758001374"));
			
			//UC5
            //PasswordRegexRule1 pattern5 = new PasswordRegexRule1();
            //Console.WriteLine(pattern5.ValidatePasswordRule1("akshaykokitkar"));
			
			//UC6
            PasswordRegexRule2 pattern6 = new PasswordRegexRule2();
            Console.WriteLine(pattern6.ValidatePasswordRule2("Akshaykumarkokitkar"));


        }
    }
}