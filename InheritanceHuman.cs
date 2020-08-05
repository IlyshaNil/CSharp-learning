using System;

namespace CSharp_learning
{
    public class InheritanceHuman
    {
        public string Name { get; set; }
        public int Age 
        { 
            get
            {
                return Age;
            } 
            set
            {
                if (value > 0 )
                {
                    Age = value;
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