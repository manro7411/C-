// See https://aka.ms/new-console-template for more information
namespace Name
{
    class Program 
    {
        static void Main(string[] args){
            string name = "Ratchanon Traitiprat\n";
            Console.WriteLine("Jamk University of Applied Science");
            Console.WriteLine("Hello, "+name);
            Console.WriteLine("{2} - {1} = {0}",5,10,15);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            // Declare variable 
            int x = 10;int y = 20;
            int result = x + y;
            Console.WriteLine("Result : "+result);

            float a =10.2f;
            float b = 10f;
            Console.WriteLine("The first number : "+a+"\nThe second number :"+b);

        }
    }
}