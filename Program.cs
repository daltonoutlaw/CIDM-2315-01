namespace Week4Lecture;

class Program
{
    static void Main(string[] args)
    {
        int a = Convert.ToInt16(Console.ReadLine());
        int b = Convert.ToInt16(Console.ReadLine());
        int c = Convert.ToInt16(Console.ReadLine());
        int d = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine($"a = {a}; b = {b}; c = {c}; d = {d}");

        Max(a,b,c,d);
    }

    static void Max(int a, int b, int c, int d)
    {
        if(a>b&&a>c&&a>d){
            Console.WriteLine($"The largest number is: {a}");
        }
        else if(b>a&&b>c&&b>d){
            Console.WriteLine($"The largest num is: {b}");
        }
        else if(c>a&&c>b&&c>d){
            Console.WriteLine($"The largest num is: {c}");
        }
        else{
            Console.WriteLine($"The largest num is: {d}");
        }
    }
}