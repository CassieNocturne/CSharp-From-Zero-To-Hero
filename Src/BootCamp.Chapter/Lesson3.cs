using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static string Name()
        {
            Console.WriteLine("Testing");
            return Console.ReadLine();
        }
        public static int Age()
        {
            Console.WriteLine("Testing");
            return int.Parse(Console.ReadLine()) ;
        }
        public static float Weight()
        {
            Console.WriteLine("Testing");
            return float.Parse(Console.ReadLine());
        }
        public static float Height()
        {
            Console.WriteLine("Testing");
            return float.Parse(Console.ReadLine());
        }
        public static float BMI(float weight, float height)
        { 
            return weight / (height * height);
        }
        public static void Demo()
        {
            string name = Name();
            int age = Age();
            float height = Height();
            float weight = Weight();
            float bmi = BMI(weight, height);
            Console.WriteLine("Hello " + name + "! You are " + age + " years of age, are " + height + "cm tall, and are " + weight + " kg. This makes your BMI " + bmi + ".");
        }
    }
}
