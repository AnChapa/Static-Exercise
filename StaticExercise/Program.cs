namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What temperature is:");
            double temp = double.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------");
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("What temperature scale is it in? Fahrenheit or Celsius:");
                string scale = Console.ReadLine().ToLower();
                switch (scale)
                {
                    case "fahrenheit":
                        Console.WriteLine($"The temperature would be {TempConverter.FahrenheitToCelsius(temp)}°C in Celsius.");
                        loop = false;
                        break;
                    case "f":
                        Console.WriteLine($"The temperature would be {TempConverter.FahrenheitToCelsius(temp)}°C in Celsius.");
                        loop = false;
                        break;
                    case "celsius":
                        Console.WriteLine($"The temperature would be {TempConverter.CelsiusToFahrenheit(temp)}°F in Fahrenheit.");
                        loop = false;
                        break;
                    case "c":
                        Console.WriteLine($"The temperature would be {TempConverter.CelsiusToFahrenheit(temp)}°F in Fahrenheit.");
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("That is not a correct temperature scale.");
                        break;
                }
            }
        }
    }
}
