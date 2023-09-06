namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input a letter grade: ");
        string letter = Console.ReadLine();
        char letter_char = Convert.ToChar(letter);
        if(letter_char == 'A'){
            Console.WriteLine("GPA Point: 4");
        }
        else if (letter_char == 'B'){
            Console.WriteLine("GPA Point: 3");
        }
        else if (letter_char == 'C'){
            Console.WriteLine("GPA Point: 2");
        }
        else if (letter_char == 'D'){
            Console.WriteLine("GPA Point: 1");
        }
        else if (letter_char == 'F'){
            Console.WriteLine("GPA Point: 0");
        }
        else{
            Console.WriteLine("Wrong Letter Grade!");
        }
    }
}
