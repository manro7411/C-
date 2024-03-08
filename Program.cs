using System.Net.Sockets;
using System.Reflection.Metadata;
namespace Name
{   
    struct Employee{
        public string namea;
        public int age;
        public double salary;
        public string department;

        public void setEmployee(string nameVal,int ageval,double salaryval,string departmentval)
        {
            namea = nameVal;
            age = ageval;
            salary = salaryval;
            department = departmentval;
        }
        public void showEmployee(){
            Console.WriteLine("Name : "+namea);
            Console.WriteLine("Age : "+age);
            Console.WriteLine("Salary : "+salary);
            Console.WriteLine("Department : "+department);
        }
        
    }
    class Program 
    {
        // structure
        
        int num = 200; // global variable
        static void Main(string[] args){
            Employee emp1 = new Employee(); // in case to declare method
            emp1.setEmployee("Ratchanon Traitiprat",30,90000.00,"Programmer");
            emp1.namea = "Ratchanon Traitiprat";
            emp1.age = 30;
            Console.WriteLine("Name = "+emp1.namea);

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

            int sw_1,sw_2,choice,totally;
            Console.Write("Input number 1 = ");
            int.TryParse(Console.ReadLine(),out sw_1);
            Console.Write("Input number 2 = ");
            int.TryParse(Console.ReadLine(),out sw_2);
            Console.Write("Input choice(1(+),2(-)) = ");
            int.TryParse(Console.ReadLine(),out choice);

            switch (choice)
            {
                case 1 :
                totally = sw_1+sw_2;
                Console.WriteLine(totally);
                break;
                case 2 :
                totally = sw_1-sw_2;
                Console.WriteLine(totally);
                break;
                default:Console.WriteLine("error");
                break;
            }
            int count = 1;
            Console.Write("Insert your number :");
            int result_final;
            int.TryParse(Console.ReadLine(),out result_final);
            while (count <= 10)
            {
                Console.WriteLine("{0} x {1} = {2}",result_final,count,result_final*count);
                count++;        
            }
            do
            {
                Console.WriteLine("Hello world = {0}",count);
                count++;   
            } while (count <= 3);   
            int sum =0,avg = 0;
            for (int i = 1; i <= 5; i++)
            {
                int num;
                Console.Write("Input number = ");
                int.TryParse(Console.ReadLine(),out num);
                sum+=num;
            }
            Console.WriteLine("Summation = {0}",sum);
            avg = sum/5;
            Console.WriteLine("Average = {0}",avg);

            // while (true)
            // {
            //       int num;
            //     Console.Write("Input number = ");
            //     int.TryParse(Console.ReadLine(),out num);
            //     if (num<0)
            //     {
            //         break;
            //     }
            //     sum+=num;   
            // }
            Console.WriteLine("Summation = {0}",sum);
            avg = sum/5;
            Console.WriteLine("Average = {0}",avg);

            int max =0; int min=int.MaxValue;
            // while (ns == 5)
            // {
            //     int n;
            //     Console.WriteLine("Input number = ");
            //     int.TryParse(Console.ReadLine(),out n);
            //     if (n>max)
            //     {
            //         max =n;  
            //     }if (n<min)
            //     {
            //         min = n;
            //     }
            // }
            Console.WriteLine("max = {0}",max);
             Console.WriteLine("min = {0}",min);

            Console.WriteLine("- - - - - Arrays - - - - -");
            int []number ={1,2,3,4,5,6};
            int []arr = new int[10]; 
            number[0] = 3000;
            Console.WriteLine("Number index : {0}",number[0]);
            double []grades = {4.00,3.50,3.00,2.00};
            Console.WriteLine("Number index : {0}",grades[0]);
            Console.WriteLine("Number index : {0}",grades.Length);
            for (int i = 0; i < grades.Length; i++)
            {
             Console.WriteLine("Number index {0} = {1}",i,grades[i]);    
            }
            foreach (var item in grades)
            {
                Console.WriteLine("Number index : {0}",item);
                
            }
            // Arrays 2D
            string[,] arr2d = new string[2,2]{
                {"a","b"},
                {"c","d"}
            };
            arr2d[0,0]="Ratchanon";
            Console.WriteLine("Number index : {0}",arr2d[0,0]);
            Console.WriteLine("Array row : {0}",arr2d.GetLength(0));
            for (int row = 0;row < arr2d.GetLength(0); row++)
            {
                for (int col = 0; col < arr2d.GetLength(1); col++)
                {
                    Console.WriteLine(arr2d[row,col]);
                }
            }
            foreach (var item in arr2d)
            {
                Console.WriteLine(item);
            }
            // Jagged Arrays 
            string[][] jaggedarr ={
            new string[] {"1","2","3"}, // 3 cols 
            new string[]{"2","3"},
            new string[]{"2","3"}
            }; // crating array -> 3 row 
            jaggedarr[0][0] = "Ratchanon";
            Console.WriteLine(jaggedarr[0][1]);

            for (int i = 0; i < jaggedarr.Length; i++)
            {
                Console.WriteLine("Row = {0}",i);
                for (int j = 0; j < jaggedarr[i].Length; j++)
                {
                    Console.WriteLine("Student jaggedar Arrays [{0},{1} = {2}]",i,j,jaggedarr[i][j]);
                }
                Console.WriteLine("########");        
            }
            //methond -> predifined method => automatic function && user-defined-method = was created bt my own
            SayHi();
            Hello("Ratchanon Traitiprat");
            Showdata("Ratchanon","Traitiprat","Thailand");
            callculator(5,10);
            string myIP = getIPaddress();
            Console.WriteLine("MY IP : {0}",myIP);
            Console.WriteLine("{0}",checknumber());
            Console.WriteLine("{0}",ttest(5,10));
            ttt(100,200);
            int[] scres = {10,20,30,40,50,60,70,80};
            int[] scresPhysic = {80,90,100,200,300};
            for (int i = 0; i < scres.Length; i++)
            {
                Console.WriteLine(scres[i]);
            }
            for (int i = 0; i < scresPhysic.Length; i++)
            {
                Console.WriteLine(scresPhysic[i]);
            }
            Console.WriteLine("----------");
            displayscore(scres);
            Console.WriteLine("----------");
            int maxx = findmaxarray(scresPhysic);
            Console.WriteLine("Max score = "+maxx);
             int minn = findminarray(scresPhysic);
            Console.WriteLine("Min score = "+minn);
            int[] cloneScore = copyArr(scres);
            for (int i = 0; i < cloneScore.Length; i++)
            {
                Console.WriteLine("Clone score = "+cloneScore[i]);  
            }
            cocacola("Ratchanon Traitiprat",20000,"Bangkok");
            cocacola("Tunwarat",20000);
            double balance = 10000; // local variable 
 
        }
        //declare method input yype
        static void SayHi(){
            Console.WriteLine("Hello c#");
        }
        static void Hello(string name){
              Console.WriteLine("Hello {0}",name);
        }
        static void Showdata(string name,string lname,string address){
            Console.WriteLine(name);
            Console.WriteLine(lname);
            Console.WriteLine(address);
        }
        static void callculator(int x,int y){
            int result = x+y;
              Console.WriteLine("Result : {0}",result);
        }

        static void ttt(int x , int y){
            if (x < 0 || y < 0)
            {
                return;
            }
            int summation = x + y;
            Console.WriteLine("Sum = {0}",summation);
        }
        //return method
        static string getIPaddress(){
            return "127.0.0.1";
        }
        static bool checknumber(){
            int nn= 50;
            if (nn % 2 == 0)
            {
                return true;
                
            }
            else
            {
                return false;
            }

        }
        static int ttest(int x,int y){
            return x + y;
        }
        static void displayscore(int []arr )
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static int findmaxarray(int[] arr)
        {   
            // arr = 10,20,30,40
            int maxValue = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                // comparision
                if (arr[i]>maxValue) //20>10
                {
                    maxValue = arr[i]; //20
                }
            }
            return maxValue;
        }
          static int findminarray(int[] arr)
        {   
            // arr = 10,20,30,40
            int minValue = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                // comparision
                if (arr[i]<minValue) 
                {
                    minValue = arr[i]; 
                }
            }
            return minValue;
        }
        static int[] copyArr(int[] oriArr){
            int [] newArr = new int[oriArr.Length];
            for (int i = 0; i < oriArr.Length; i++)
            {
                newArr[i] = oriArr[i];
            }
            return newArr;
        }
        static void cocacola(string name,double salary,string address="Bangkok"){
            Console.WriteLine("Name : {0} Salary : {1} Address :{2}",name,salary,address);
        }
    }
}