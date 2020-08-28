using System;


namespace CSharp_learning
{
    public class Animal : SubTypePoly
    {
        public string Name { get; set; }

        public virtual void GetRoar()
        {
            Console.WriteLine("Default text");

        }
        
    }

    public class Cat : Animal
    {
        public override void GetRoar()
        {
            Console.WriteLine("Мяу");
        }

    }

    public class Dog : Animal
    {
        public override void GetRoar()
        {
            Console.WriteLine("ащущенне сатбильнасци!");
        }

    }

    public class Boozer : Animal
    {
        public override void GetRoar()
        {
            Console.WriteLine("Был бы ты человеком!");
            base.GetRoar();
        }
        
    }
}