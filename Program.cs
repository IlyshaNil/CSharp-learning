using System;

namespace CSharp_learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int result;
            BasicClass myClass = new BasicClass();
            result = myClass.FindMax(30, 30);

            int propertyResult;
            PropertiesClass myProperty = new PropertiesClass();
            propertyResult =  myProperty.propertyValue;

            

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
