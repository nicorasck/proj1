namespace proj1;

class Program
{
    static void Main(string[] args)//tar bort loopen och klistrar in den i min nya metod 'MyLoop'.
    {
        Console.WriteLine("Program begin");
        MyLoop(3);
        MyLoop(10);
        Console.WriteLine("\nProgram end.");   
    } 

    static void MyLoop(int nrIterations)//metod med loopen, anropar den i Main-metoden.
    {
        {
            int sum = 0;

            for (int i = 0; i < nrIterations; i++)
            {
                sum += i;
                Console.WriteLine($"i = {i}\nsum ={sum}");

                if (sum == 3)
                {
                    Console.WriteLine("We have now the magical sum of 3\n");
                }
            }
        }
    }
       
}



