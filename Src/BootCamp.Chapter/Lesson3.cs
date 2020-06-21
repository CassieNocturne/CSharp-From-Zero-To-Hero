using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        static string name = Name();
        static int age = Age();
        static float height = Height();
        static float weight = Weight();
        static float bmi = BMI();
        public static string Name()
        {
            Console.WriteLine("Please input your first and last name: ");
            return Console.ReadLine();
        }
        public static int Age()
        {
            Console.WriteLine("Please input your age: ");
            return int.Parse(Console.ReadLine()) ;
        }
        public static float Weight()
        {
            Console.WriteLine("Please input your weight, in kg: ");
            return float.Parse(Console.ReadLine());
        }
        public static float Height()
        {
            Console.WriteLine("Please input your height, in m");
            return float.Parse(Console.ReadLine());
        }
        public static float BMI()
        { 
            return weight / (height * height);
        }
        public static void Demo()
        {
            Console.WriteLine("Hello " + name + "! You are " + age + " years of age, are " + height + "cm tall, and are " + weight + " kg. This makes your BMI " + bmi + ".");
        }
    }
}
