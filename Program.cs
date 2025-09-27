using System;  //Currentlu using means using system name classes
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Lectures_C_
{
    internal class Program
    {
        //New function
        static void Greet()
        {
            Console.WriteLine("function");
            Console.WriteLine("Finally you do");
        }


        static float Average(int a,int b,int c)
        {
            float sum = a + b + c;
            return sum/3;
        }


        static float Average(int a, int b)
        {
            float sum = a + b;
            return sum / 2;
        }
        //Main Function start here
        static void Main()
            {
                //simple output
                //Instructions
                Console.WriteLine("Hello Tanzeela");

                //Variables
                int a = 56;
                Console.WriteLine(" String with variable :" + a);

                //Data Types
                int i = 2;       //Integer
                char b = 'A';     //CHaracter
                float f = 9.9F;     //floating point
                bool d = true;   //Boolean
                string s = "Hi ,I am Here";          //Store word,line,sentences
                long l = -90;   // take long values
                double e = 9009D;   //Double
                Console.WriteLine("int :" + i);
                Console.WriteLine("Char :" + b);
                Console.WriteLine("float :" + f);
                Console.WriteLine("string :" + s);
                Console.WriteLine("long :" + l);
                Console.WriteLine("double :" + e);
                Console.WriteLine("bool :" + d);


                //Input taking
                string get = Console.ReadLine();  //readline return string
                Console.WriteLine("Enter value:" + get);


                //Type Casting

                int t = (int)3.90;  //double value converting to int
                Console.WriteLine("Type Catsing :" + t);

                //Implicit Casting
                //char to int to long to float to double

                int m = 90;
                double n = m;
                int z = 'y';
                Console.WriteLine("Int Convert into double :" + n);
                Console.WriteLine("Character convert into number :" + z);

                //Explicit Casting

                int x1 = (int)56.0;
                Console.WriteLine("Explicit Casting :" + x1);


                //Type conversionn method

                float x2 = (float)Convert.ToDouble(3.90);
                Console.WriteLine("Type conversion method :" + x2);

                Console.WriteLine("Enter your name");
                string name = Console.ReadLine();
                Console.WriteLine("Hey Hello " + name);


                //get input from user 

                Console.WriteLine("How many candies you want");
                string can = Console.ReadLine();

                // en mn sy koe aq string ho ga to sub ko string bna dy ga
                //but edr phly string ko integer mn convert keya then coceterate keya

                Console.WriteLine("You will get 4 more candies " +
                    (Convert.ToInt32(can) + 4));
                Console.ReadLine();


                //Operators

                //1.Arithmetic Operator

                int one = 4;
                int two = 5;
                Console.WriteLine("The value of a+b :" + (one + two));
                Console.WriteLine("The value of a-b :" + (one - two));
                Console.WriteLine("The value of a*b :" + (one * two));
                Console.WriteLine("The value of /+b :" + (one / two));
                //2.Logical Operator

                Console.WriteLine("Logical Operator\n");
                Console.WriteLine(true || true);
                Console.WriteLine(true || false);
                Console.WriteLine(false || false);
                Console.WriteLine(false || true);

                Console.WriteLine(false || false);
                Console.WriteLine(false || true);
                Console.WriteLine(true || false);
                Console.WriteLine(true || true);


                Console.WriteLine(!false);
                Console.WriteLine(!true);

                //3.Assignment Operator

                Console.WriteLine("Assignmnet Operator");
                int ass = 90;
                Console.WriteLine(ass);
                a += 90;
                Console.WriteLine(a);
                a -= 8;
                Console.WriteLine(a);
                a *= 2;
                Console.WriteLine(a);
                a /= 5;
                Console.WriteLine(a);

                //4.Comparision Operator

                Console.WriteLine("Comparison Operator");
                Console.WriteLine(455 > 90);
                Console.WriteLine(89 < 9);
                Console.WriteLine(80 <= 80);
                Console.WriteLine(9 >= 90);
                Console.WriteLine(9 == 9);
                Console.WriteLine(9 != 9);


                //Math class

                Console.WriteLine("Using Math class");
                int max = Math.Max(9, 90);
                Console.WriteLine(max);

                //1. sqrt
                //2. max 
                //3. min
                //4. abs =absulaate
                //5. round

                //String Function

                Console.WriteLine("String Functions");
                string hello = "This is me :";
                Console.WriteLine(hello.Length);
                Console.WriteLine(hello.ToLower());
                Console.WriteLine(hello.ToUpper());
                Console.WriteLine(hello + "You rae me");
                Console.WriteLine(String.Concat(hello + "ioh"));

                //String interpollination

                string names = Console.ReadLine();
                Console.WriteLine($"Yourname is  {names}");
                Console.WriteLine(names[4]);
                Console.WriteLine(hello.IndexOf("is"));
                Console.WriteLine(hello.Substring(5));


                //String Escape sequences

                //\n
                //\t
                Console.WriteLine("Escape sequences \" String");


                //Decision making 

                //if else condition
                Console.WriteLine("If condition");
                int age = 30;
                if (age > 18)
                    Console.WriteLine("You can drive");
                else
                    Console.WriteLine("You cannot write");

                //if else if condition

                Console.WriteLine("If esle if Condition");
                Console.Write("Enter Your age:");
                String YAge = Console.ReadLine();
                int YourAge = Convert.ToInt32(YAge);  //Convert string into integer
                if (YourAge > 18)
                    Console.WriteLine("You can drive");
                else if (YourAge == 18)
                    Console.WriteLine("You are eligible for drive");
                else
                    Console.WriteLine("You can't drive");

                //Switch Condition

                Console.WriteLine("Switch Condition");
                int AAge = 90;
                switch (AAge)
                {
                    case 18:
                        Console.WriteLine("You are 18");
                        break;
                    case 90:
                        Console.WriteLine("You are too old");
                        break;
                    default:
                        Console.WriteLine("Break");
                        break;
                }

                //***Loops***

                Console.WriteLine("Loops");

                //while loop

                Console.WriteLine("While loop");
                int y = 0;
                while (y < 6)
                {
                    Console.WriteLine(y);
                    y++;
                }

                //Do While Loop

                Console.WriteLine("Do while loop");
                int x = 0;
                do
                {
                    Console.Write(x + 1);
                    x++;
                }
                while (i < 5);

                //For loop

                Console.WriteLine("For loop");
                for (int A_loop = 0; A_loop < 20; A_loop++)
                {
                    Console.WriteLine(A_loop);
                }

                //Break

                Console.WriteLine("Break");
                for (int A_loop = 0; A_loop < 5; A_loop++)
                {
                    Console.WriteLine(A_loop);
                    if (A_loop == 3)
                        break; //leave this loop forever
                }

                //Continue

                Console.WriteLine("Continue");
                for (int A_loop = 0; A_loop < 5; A_loop++)
                {
                    if (A_loop == 0)
                        continue;   //Move on next commands skip this for now 
                    Console.WriteLine(A_loop);
                }


            //Function

            Greet();
            float avg= Average(2, 7, 9);
            Console.WriteLine(avg);
            Console.WriteLine(Average(2, 7, 9));
            Console.WriteLine(Average(2, 7));


            // Run clas and objects in OOPs using C#

            OOPs oOPs = new OOPs();
            Console.WriteLine(oOPs.name);


        }
    }
}
