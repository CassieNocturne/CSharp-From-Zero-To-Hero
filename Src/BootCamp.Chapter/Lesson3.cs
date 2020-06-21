using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        //declaring varibales from function
        static string name = Name();
        static int age = Age();
        static float height = Height();
        static float weight = Weight();
        static float bmi = BMI();
        //these are the functions that fetch user information.
        public static string Name()
        {
            Console.WriteLine("Please input your first and last name: ");
            string name = Console.ReadLine();
            return name;
        }
        public static int Age()
        {
            Console.WriteLine("Please input your age: ");
            int age = int.Parse(Console.ReadLine());
            return age;
        }
        public static float Weight()
        {
            Console.WriteLine("Please input your weight, in kg: ");
            float weight = float.Parse(Console.ReadLine());
            return weight;
        }
        public static float Height()
        {
            Console.WriteLine("Please input your height, in cm");
            float height = float.Parse(Console.ReadLine());
            return height;
        }
        public static float BMI()
        {
            float bmi = weight / ((height / 100) * (height / 100));
            return bmi;
        }
        public static void Demo()
        {
            Console.WriteLine("Hello " + name + "! You are " + age + " years of age, are " + height + "cm tall, and are " + weight + " kg. This makes your BMI " + bmi + ".");
        }
    }
}
