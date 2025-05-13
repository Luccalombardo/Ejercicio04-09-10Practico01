namespace Ejercicio10.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("El programa que permite ingresar una cantidad de peso en gramos, kilogramos u onzas, y luego convertirla a las otras dos unidades");

            double kilogramos, gramos, onzas, peso, libras;
            int tipoPeso;

            Console.WriteLine("Introduzca el tipo de peso que va a ingresar segun el numero que indique: ");
            Console.WriteLine("(1)Kilogramos");
            Console.WriteLine("(2)Gramos");
            Console.WriteLine("(3)Onzas");
            Console.WriteLine("(4)Libras");

            tipoPeso = int.Parse(Console.ReadLine());

            if (tipoPeso == 1)
            {
                Console.WriteLine("Ingrese la cantidad de kilogramos");
                peso = double.Parse(Console.ReadLine());
                gramos = peso *1000;
                onzas = peso * 35.274;
                libras = peso * 2.2046;

                Console.WriteLine($"Los {peso} kilogramos son...");
                Console.WriteLine($"{gramos} gramos");
                Console.WriteLine($"{onzas} onzas");
                Console.WriteLine($"{libras} libras");

            }
            else if (tipoPeso == 2) 
                
            {
                Console.WriteLine("Ingrese la cantidad de gramos");
                peso = double.Parse(Console.ReadLine());
                kilogramos = peso / 1000;
                onzas = kilogramos * 35.274;
                libras = kilogramos * 2.2046;

                Console.WriteLine($"Los {peso} gramos son...");
                Console.WriteLine($"{kilogramos} kilogramos");
                Console.WriteLine($"{onzas} onzas");
                Console.WriteLine($"{libras} libras");

            }
            else if (tipoPeso == 3)
            {
                Console.WriteLine("Ingrese la cantidad de onzas");
                peso = double.Parse(Console.ReadLine());
                kilogramos = peso / 35.274;
                gramos = kilogramos * 1000;
                libras = kilogramos * 2.2046;

                Console.WriteLine($"Los {peso} onzas son...");
                Console.WriteLine($"{gramos} gramos");
                Console.WriteLine($"{kilogramos} kilogramos");
                Console.WriteLine($"{libras} libras");

            }
            else if (tipoPeso == 4)
            {
                Console.WriteLine("Ingrese la cantidad de libras");
                peso = double.Parse(Console.ReadLine());
                kilogramos = peso / 2.2046;
                gramos = kilogramos * 1000;
                onzas = kilogramos * 35.274;

                Console.WriteLine($"Los {peso} libras son...");
                Console.WriteLine($"{gramos} gramos");
                Console.WriteLine($"{onzas} onzas");
                Console.WriteLine($"{kilogramos} kilogramos");

            }
            else
            {
                Console.WriteLine("ERROR: Valor no valido");
            }
        }
    }
}

//a. 1 kilogramo=1000 gramos.
//b. 1 kilogramo = 35.274 onzas.
//c. 1 kilogramo = 2.2046 libras
