namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Write out operations for addition, subtraction, and multiplication.
            

          

            //For division, create two integer variables
            int a = 17;
            int b = 4;
            var sum = a + b;
            int difference = a - b;
            int product = a * b;
            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

            Console.WriteLine("Please enter the radius of your circle:");
            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            Console.WriteLine(AreaOfCircle(radius));
        }
        // define a method - which performs some functionality. That can be used again
        public static double AreaOfCircle(double radius)
        { 
            var area = Math.PI * Math.Pow(radius, 2);


        }
    }
}
