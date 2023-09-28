namespace Week4Lecture;

class Program
{
    static void Main(string[] args)
    {
        createAccount(); 
    }

    static bool checkAge(int birth_year)
    {
        int age = 2023-birth_year;
        if(age>=18){
            return true;
        }
        else{
            return false;
        }
    }

    static void createAccount()
    {
        Console.WriteLine("Enter Your Username:");
        string username = Console.ReadLine();
        Console.WriteLine("Enter Your Password:");
        string password = Console.ReadLine();
        Console.WriteLine("Enter Your Password Again:");
        string re_password = Console.ReadLine();
        Console.WriteLine("Enter Your Birthyear:");
        int birth_year = Convert.ToInt16(Console.ReadLine());

        if(birth_year >= 2005){
            if(password == re_password){
                Console.WriteLine("Account is created successfully");
            }
            else{
                Console.WriteLine("Wrong passowrd");
            }
        }    
    }
}
