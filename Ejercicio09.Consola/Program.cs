namespace Ejercicio09.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingresar una temperatura en grados Celsius y convertirla a grados Reaumur y a grados Fahrenheit.");
                double celsius, reaumur, fahrenheit;

                Console.Write("Ingresar una temperatura en grados Celsius para convertir: ");
                celsius = double.Parse(Console.ReadLine());

                reaumur = transformacionReaumur(celsius);
                fahrenheit = transformacionFahrenheit(celsius);
                

                Console.WriteLine($"En {celsius} grados Celsius hay....:");
                Console.WriteLine($"{reaumur} grados Reaumur");
                Console.WriteLine($"{fahrenheit} grados Fahrenheit");

                Console.ReadKey();
            }
            catch (FormatException ex)
            {

                Console.WriteLine("ERROR: El formato ingresado no es valido");
            }
            catch (Exception ex)
            {

                Console.WriteLine("ERROR: Excepcion no manejada");
            }
        }

        private static double transformacionFahrenheit(double celsius)
        {
            return 1.8 * celsius + 32;
        }

        private static double transformacionReaumur(double celsius)
        {
            return 0.8 * celsius;
        }
    }
}
