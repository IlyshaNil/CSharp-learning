using System;

namespace CSharp_learning
{
    public class InheritanceHuman
    {
        public string Name { get; set; }
        private int age;
        public int Age 
        { 
            get
            {
                return age;
            } 
            set
            {
                if (value > 0 )
                {
                    age = value;
                }
            } 
        }
        public string Sex {get; set; }

        public void SayHelloToSomebody()
        {
            Console.WriteLine("Ну здарова!");
        }

        

    }
}