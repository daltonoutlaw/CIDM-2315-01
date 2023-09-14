namespace Week4Lecture;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input an integer: ");
        int N = Convert.ToInt16(Console.ReadLine());
        int i = 2;
        while(N >= i)
        {
            if(N == 2){
                Console.WriteLine("N is prime");
                break;
            }
            else if(N%i == 0){
                Console.WriteLine("N is non-prime");
                break;
            }
            else if(N%i != 0){
                Console.WriteLine("N is prime");
                break;
            }
            i++;
        }
    }
}
