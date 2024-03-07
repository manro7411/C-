using System.Net.Sockets;
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
            Console.WriteLine(first == second);
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
            Console.WriteLine("Square Root = {0}",Math.Sqrt(25));

            Console.WriteLine("Original number = {0}",first);
            Console.WriteLine("Posfix result = {0}",first++);
            Console.WriteLine("final result = {0}",first);

            Console.WriteLine("Original number_1 = {0}",first);
            Console.WriteLine("Posfix result = {0}",first--);
            Console.WriteLine("final result_1 = {0}",first);
            first = first + second; // first += second
            Console.WriteLine(first);
            float calculator = 5+8*9;
            Console.WriteLine(calculator);
            switch (first = 2)
            {
                case 1:
                Console.WriteLine("Hello world");
                break;

                 case 2:
                Console.WriteLine("Hello world_2");
                break;
            }
             Console.WriteLine("- - - - - Convert - - - - -");
            string mystring = "120";
            Console.WriteLine("string = {0}",mystring);
            byte mybyte = (byte)Convert.ToSByte(mystring);
            short myshort = Convert.ToInt16(mystring);
            int myInt = Convert.ToInt32(mystring);
            long mylong = Convert.ToInt64(mystring);
            float myfloat = Convert.ToSingle(mystring);
            double mydouble = Convert.ToDouble(mystring);
            Console.WriteLine("byte = {0}",mybyte+120);
            Console.WriteLine("short = {0}",myshort+20);
            Console.WriteLine("Int = {0}",myInt+200);
            Console.WriteLine("Long = {0}",mylong+250);
            Console.WriteLine("float = {0}",myfloat+20);
            Console.WriteLine("double = {0}",mydouble+230);
            Console.WriteLine("- - - - - Parse - - - - -");
            byte _byte = byte.Parse(mystring);
            Console.WriteLine("byte = {0}",_byte+100);
            short _short = short.Parse(mystring);
            Console.WriteLine("short = {0}",_short+120);
            int _int = int.Parse(mystring);
            Console.WriteLine("int = {0}",_int+10);

            String mt = "125.5";
            int resuotmyint;
            bool success = int.TryParse(mt,out resuotmyint);
            Console.WriteLine("Tryparse = {0}",success);

            // narrowing casting
            double fist = 100.15;
            int sed = (int)first;
            Console.WriteLine(fist);
            float t1 = (float)fist;
            Console.WriteLine(t1);

            // assignment 1
            double weight,height;
            Console.WriteLine("Please insert your weight");
            double.TryParse(Console.ReadLine(),out weight);
            Console.WriteLine("Please insert your height");
            double.TryParse(Console.ReadLine(),out height);
            // bmi = weight/height^2
            height/=100;
            double bmi = weight/ Math.Pow(height,2);
            Console.WriteLine("BMI = {0:F2}",bmi);

            Console.WriteLine("Please insert your score : ");

            int score;
            string grade;
            int.TryParse(Console.ReadLine(),out score);
            
            if (score >= 80)
            {
                grade = "Grade A";
            }else if (score >=70 && score <=79)
            {
                  grade = "Grade B";
                
            }
            else if (score >=60 && score <=69)
            {
                  grade = "Grade C";
                
            }
            else if (score >=50 && score <=59)
            {
                  grade = "Grade D";
                
            }else
            {
                 grade = "Grade F";
            }
            Console.WriteLine("Grade = {0} , Score = {1}",grade,score);
            int odd_checking = 10;
            int num_checking;
            Console.Write("Input number = ");
            int.TryParse(Console.ReadLine(),out num_checking);

            if (num_checking%2 == 0)
            {
                Console.WriteLine("{0} is Even number",odd_checking);
            }else
            {
                 Console.WriteLine("{0} is Odd number",odd_checking);
            }
            String gender = "male";
            int heights = 160;
            if (gender == "male" && heights>= 160)
            {
                   Console.WriteLine("Pass");
            }else
            {
                   Console.WriteLine("Not pass");
            }
            // Console.WriteLine("- - - - - ternary operator - - - - - ");
            // result = (score >= 50) ? "Pass": "Not pass";
            int money = 30000;
            if (money >= 15000)
            {
                Console.WriteLine(" Sale !! ");
                if (money == 15000)
                {
                    Console.WriteLine("10% discount");
                }else if (money == 20000)
                {
                    Console.WriteLine("20% discount");
                    
                }else if (money == 30000)
                {
                    Console.WriteLine("30% discount");
                    
                }
            }else
            {
                Console.WriteLine("Not sale !!");
            }
            
        }
    }
}