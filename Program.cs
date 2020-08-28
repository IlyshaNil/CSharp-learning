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
            

            
            
            Animal[] animals = new Animal[3];
            Cat cat  = new Cat();
            cat.Name = "Barsik";

            Dog dog = new Dog();
            dog.Name = "Zabaka";

            Boozer savelich = new Boozer();
            savelich.Name = "Pasha";

            animals[0] = cat;
            animals[1] = dog;
            animals[2] = savelich;

            for(int i = 0; i < animals.Length; i++)
            {
                animals[i].GetRoar();
            
            }

            

            AdHocPoly overload = new AdHocPoly();
            Console.WriteLine(overload.GetMax(2, 5));
            Console.WriteLine(overload.GetMax("dfg", "dgfeg"));
            Console.WriteLine(overload.GetMaxParam(2,45,32,34,45,2,234,243,324,3,0));



        }
    }
}
