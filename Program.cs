namespace Name
{   
    class Program 
    {
        static void Main(string[] args){
            string name = "Ratchanon Traitiprat\n";
            string hello = "Hello world";
            Console.WriteLine("Jamk University of Applied Science");
            Console.WriteLine("Hello, "+name);
            Console.WriteLine("{2} - {1} = {0}",5,10,15);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            int x = 10;int y = 20;
            x = 100;
            int result = x + y;
            Console.WriteLine("Result : "+result);
            float a =10.2f;
            float b = 10f;
            Console.WriteLine("The first number : "+a+"\nThe second number :"+b);
            double number1 = 10.2;
            double number2 = 11.5;
            Console.WriteLine("Result Double :"+number1+number2);
            Console.WriteLine(string.Compare(name,hello));
            const float PI = 3.14f; // Constant variable
            int num1 = 1234567;
            Console.WriteLine("Number = {0}",num1); // normal
            Console.WriteLine("Number : {0:E}",num1);
            Console.WriteLine("Number : {0:F4}",num1);
            Console.WriteLine("Number : {0:G}",num1);
            Console.WriteLine("Number : {0:N}",num1);
            Console.WriteLine("Number : {0:P}",num1);
            Console.WriteLine("Number : {0:X}",num1);

            float testing_number = 12.45f;

            int first = 10;int second = 20;
            Console.WriteLine("Result = {0}",first+second);
            if (first <= second)
            {
                Console.WriteLine("The result is true !");
            }else{
                Console.WriteLine("Something went wrong !");
            }
            Console.WriteLine("Abs = {0}",Math.Abs(testing_number));
            Console.WriteLine("Ceiling = {0}",Math.Ceiling(testing_number));
            Console.WriteLine("Floor = {0}",Math.Floor(testing_number));
            Console.WriteLine("Round = {0}",Math.Round(testing_number));
            Console.WriteLine("Power = {0}",Math.Pow(5,2));

        }
    }
}