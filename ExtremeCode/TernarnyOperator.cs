using System;

public class Class1
{
    public TernarnyOperator()
    {
        static void Main()
        {
            Console.WriteLine("Введите число");
            int Number = Convert.ToInt32(Console.ReadLine());

            string result = x > 100 ? "боольше 100" : "меньше ста";
            Console.WriteLine(Convert.ToString(Number) + result);
            Console.ReadLine();

        }
    }
}
