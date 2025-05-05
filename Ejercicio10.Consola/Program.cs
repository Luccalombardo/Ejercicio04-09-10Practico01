namespace Ejercicio10.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("El programa que permite ingresar una cantidad de peso en gramos, kilogramos u onzas, y luego convertirla a las otras dos unidades");

            double kilogramos, gramos, onzas;
            string tipoPeso;

            Console.Write("Introduzca el tipo de peso que va a ingresar: ");
            tipoPeso = Console.ReadLine();

            if (tipoPeso == "kilogramos")
            {
                Console.WriteLine("Kilos");
            }
            else if (tipoPeso == "gramos") 
                
            {
                Console.WriteLine("gramos");
            }
            else if (tipoPeso == "onzas")
            {
                Console.WriteLine("onzas");
            }
            else
            {
                Console.WriteLine("ERROR: Valor no valido");
            }
        }
    }
}
