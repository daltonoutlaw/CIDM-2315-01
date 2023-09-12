namespace Week4Lecture;

class Program
{
    static void Main(string[] args)
    {
        int a = Convert.ToInt16(Console.ReadLine());
        int b = Convert.ToInt16(Console.ReadLine());
        Console.Write($"a = {a}; ");
        Console.WriteLine($"b = {b}");
        if(a>b){
            Console.WriteLine($"The largest number is: {a}");
        }
        else{
            Console.WriteLine($"The largest number is: {b}");
        }
    }
}
