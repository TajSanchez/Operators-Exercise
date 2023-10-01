namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            Console.WriteLine($" 10 + 20 = {num1 + num2}");

            int num3 = 67;
            int num4 = 12;
            Console.WriteLine($" 67 - 12 = {num3 - num4}");

            int num5 = 568;
            int num6 = 3;
            Console.WriteLine($" 568 * 3 = {num5 * num6}");

            int num7 = 200;
            int num8 = 20;
            Console.WriteLine($" 200 / 20 = {num7 + num8}");

            int a = 17;
            int b= 4;
            int remainder = a % b;
            Console.WriteLine($" 17 / 4 is  {a / b} remainder {remainder}");

            Console.WriteLine("Please enter a number to find the radius.");
            double Radius = Convert.ToDouble((Console.ReadLine()));
            double AreaOfACirlce = Math.PI * Math.Pow(Radius, Radius);
            Console.WriteLine($" The area of circle with the radius of {Radius} is {AreaOfACirlce}");
             


        
        }
    }
}
