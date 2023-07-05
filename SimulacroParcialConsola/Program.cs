using System;

class Program
{
    static void Main(string[] args)
    {
        double Generatriz, Altura, Radio, Area, Volumen;

        Console.Write("Ingrese la generatriz del cono: ");
        while (!double.TryParse(Console.ReadLine(), out Generatriz) || Generatriz <= 0)
        {
            Console.WriteLine("El valor ingresado debe ser un número mayor que cero");
            Console.Write("Ingrese la generatriz del cono: ");
        }

        Console.Write("Ingrese la altura del cono: ");
        while (!double.TryParse(Console.ReadLine(), out Altura) || Altura <= 0)
        {
            Console.WriteLine("El valor ingresado debe ser un número mayor que cero");
            Console.Write("Ingrese la altura del cono: ");
        }

        Console.Write("Ingrese el radio de giro del cono: ");
        while (!double.TryParse(Console.ReadLine(), out Radio) || Radio <= 0)
        {
            Console.WriteLine("El valor ingresado debe ser un número mayor que cero");
            Console.Write("Ingrese el radio de giro del cono: ");
        }

        Area = Math.PI * Radio * (Radio + Generatriz);
        Volumen = 1 / 3.0 * Math.PI * Math.Pow(Radio, 2) * Altura;

        Console.WriteLine("El área del cono es: " + Area.ToString("F3"));
        Console.WriteLine("El volumen del cono es: " + Volumen.ToString("F3"));

        Console.ReadLine();
    }
}
