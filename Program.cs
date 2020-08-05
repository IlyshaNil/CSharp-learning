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
            Console.WriteLine(propertyResult);
            

            InheritanceBoozer Seva = new InheritanceBoozer();
            Seva.Age = 54;
            Seva.Name = "Seva";
            Seva.Sex = "Genderfluid";
            Seva.SayHelloToSomebody();


            InheritanceOldBoozer Herald = new InheritanceOldBoozer();
            Herald.Age = 228;
            Herald.Name = "From Rivia";
            Herald.Sex = "Deep hetero";
            Herald.Fight();
            

            
        }
    }
}
