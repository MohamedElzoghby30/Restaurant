using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1
{

    //Mohamed Abdel latif Elzoghby  less 68    Mathematics and Computer Science

    internal class Program
    {

      
        static void Main(string[] args)
        {     int sum=0;
            Food<string> myfood = new Food<string>() ;
           

            Operation myresult = new Operation();
            Console.WriteLine(" \t \t \t \t \t Hello sir in MZ Restaurant \n \n");
            Console.WriteLine("     note: You will talk with a Boot\n");
            Console.Write("please enter your name :");
            myfood.Name=Console.ReadLine();
            Console.Write("please enter your phone number :");
            myfood.Number = Console.ReadLine();
            Console.Write("please enter your adress :");
            myfood.Adress = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("hello Mr/Mrs {0} are you want pizza or sandwich or together \n \t note the pizza one size ", myfood.Name);
            Console.WriteLine("one pizza=50  one sandwich=30  any delivery=30 ");
            string food =Console.ReadLine();
            if (food == "pizza")
            {   
                Console.WriteLine("please enter number of pizza");
                int num = int.Parse(Console.ReadLine());
                 sum = myresult.pizza(num);

            }
            else if (food == "sandwich") 
            {
                Console.WriteLine("please enter number of sandwich");
                int num = int.Parse(Console.ReadLine());
                sum = myresult.sundaw(num);
            }

            else if(food == "together")
            {
                Console.WriteLine("please enter number of pizza");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("please enter number of sandwich");
                int num2 = int.Parse(Console.ReadLine());
                 sum = myresult.tog(num1, num2);
            }

            Console.Clear();
         
           Console.WriteLine("ok Mr/Mrs {0} your check = {1} is total the food and Delivery ",myfood.Name,sum+30);
           Console.WriteLine("your Request is fininsh at 30 minutes at {0} ",myfood.Adress);
           

        }
    }
}
