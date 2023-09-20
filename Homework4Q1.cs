namespace Week4Lecture;

class Program
{
    static void Main(string[] args)
    {
        Greatest();
    }

    static void Greatest()
    {
        int a=Convert.ToInt16(Console.ReadLine());
        int b=Convert.ToInt16(Console.ReadLine());
        Console.WriteLine($"a = {a}; b = {b}");
        if(a>b){
            Console.WriteLine($"The largest num is: {a}");
        }
        else{
            Console.WriteLine($"The largest num is: {b}");
        }
    }


}
