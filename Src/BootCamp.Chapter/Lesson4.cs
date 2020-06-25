using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static string Name()
        {
            Console.WriteLine("Testing");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.Write("Name cannot be empty.");
                return "-";
            }
            else
            {
                return name;
            }
        }
        public static int Age()
        {
            Console.WriteLine("Testing");
            int userage;
            string input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out userage);
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            if (!isNumber)
            {
                Console.Write("\"" + input + "\"" + " is not a valid number.");
                return -1;
            }
            else if (userage == 0)
            {
                return 0;
            }
            else
            {
                return userage;
            }
        }
        public static float Weight()
        {
            Console.WriteLine("Testing");
            float userweight;
            string input = Console.ReadLine();
            bool isNumber = float.TryParse(input, out userweight);
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            else if (!isNumber)
            {
                Console.Write("\"" + input +"\"" + " is not a valid number.");
                return -1;
            }
            else if (userweight == 0)
            {
                return 0;
            }
            else
            {
                return userweight;
            }
        }
        public static float Height()
        {
            Console.WriteLine("Testing");
            int userheight;
            string input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out userheight);
            if (!isNumber)
            {
                Console.WriteLine("\"" + input + "\"" + " is not a valid number.");
                return -1;
            }
            else if (userheight == 0)
            {
                return 0;
            }
            else
            {
                return userheight;
            }
        }
        public static float BMI(float weight, float height)
        {
            if ((weight > 0) && (height > 0))
            {
                return weight / (height * height);
            }
            else if ((weight <= 0) && (height <= 0))
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine("Weight cannot be equal or less than zero, but was " + weight + ".");
                Console.WriteLine("Height cannot be less than zero, but was " + height + ".");
                return -1;
                
            }
            else if (height <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine("Height cannot be equal or less than zero, but was " + height + ".");
                return -1;
            }
            else
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine("Weight cannot be equal or less than zero, but was " + weight + ".");
                return -1;
            }
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
