namespace Ejercicio04.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Informar la superficie y el perímetro de una circunferencia");

                double Radio, Pi;
                double perimetro, superficie;

                Console.Write("Ingrese el valor de la Radio del Circulo: ");
                Radio = double.Parse(Console.ReadLine());
                Pi = 3.14159265359;




                perimetro = perimetroDelCirculo(Radio, Pi);
                superficie = superficieDelCirculo(Radio, Pi);

                Console.WriteLine($"El circulo con una Radio de {Radio} tiene un perímetro de {perimetro}");
                Console.WriteLine($"El circulo con una Radio de {Radio} tiene una superficie de {superficie}");
            }
            catch (FormatException ex)
            {

                Console.WriteLine("ERROR: El formato ingresado no es valido");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Excepcion no manejada");
            }
        }

        private static double superficieDelCirculo(double radio, double pi)
        {
            return pi * Math.Pow(radio,2);
        }

        private static double perimetroDelCirculo(double radio, double pi)
        {
            return 2*pi*radio;
        }
    }
}
//a.Perímetro = 2 * π * Radio
//b.Superficie = π ∗ Radio^2