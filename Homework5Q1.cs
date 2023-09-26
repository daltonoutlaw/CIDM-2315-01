namespace Week4Lecture;

class Program
{
    static void Main(string[] args)
    {
        int a = Convert.ToInt16(Console.ReadLine());
        int b = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine($"a = {a}; b = {b}");

        Max(a,b);
    }

    static void Max(int a, int b)
    {
        if(a>b){
            Console.WriteLine($"The largest number is: {a}");
        }
        else{
            Console.WriteLine($"The largest num is: {b}");
        }
    }
}
