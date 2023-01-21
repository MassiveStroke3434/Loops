namespace Loops;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please Enter a Number:");
        int target = int.Parse(Console.ReadLine());
        for (int i = 1; i <= target; i++)
        {
            if(i%2==1)
                Console.WriteLine(i);
        }
    }
}
