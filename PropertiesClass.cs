namespace CSharp_learning
{
    public class PropertiesClass
    {
        private int fieldInt = 5;
        private string fieldString = "Properties better than fields";

        private int fieldValue;

        public int propertyValue 
        {
            get
            {
                return fieldValue;
            }
            private set
            {
                if (true)
                {
                fieldValue = value;
                }
            }
        }

        public string autoProperty { get; set; } = "default";
    }
}