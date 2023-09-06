namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input a year: ");
        string year = Console.ReadLine();
        int year_int = Convert.ToInt16(year);
        if(year_int%100 == 0){
            if(year_int%400 == 0){
                Console.WriteLine(year_int+"is a leap year");
            }
            else{//year_int%100<=0
                Console.WriteLine(year_int+"is not a leap year");
            }
        }
        else{
            if(year_int%4 == 0){
                Console.WriteLine(year_int+"is a leap year");
            }
            else{//year_int%4<=0
                Console.WriteLine(year_int+"is a not leap year");
            }
        }
    }
}
