namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input the first num: ");
        string num_1 = Console.ReadLine();
        Console.WriteLine("Please input the second num: ");
        string num_2 = Console.ReadLine();
        Console.WriteLine("Please input the third num: ");
        string num_3 = Console.ReadLine();
        int num_1_int = Convert.ToInt16(num_1);
        int num_2_int = Convert.ToInt16(num_2);
        int num_3_int = Convert.ToInt16(num_3);
        if(num_1_int<num_2_int){
            if(num_1_int<num_3_int){
                Console.WriteLine("The smallest value is: "+num_1_int);
            }
            else{//n1>=n3
                Console.WriteLine("The smallest value is: "+num_3_int);
            }
        }
        else{//n2<=n1
            if(num_2_int<num_3_int){
                Console.WriteLine("The smallest value is: "+num_2_int);
            }
            else{//n3<=n2
                Console.WriteLine("The smallest value is "+num_3_int);
            }
        }
    }
}
