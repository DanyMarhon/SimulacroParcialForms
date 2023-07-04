using System;
class Program
{
    static void Main(string[] args)
    {
        double Generatriz, Altura, Radio, Area, Volumen;

        Console.Write("Ingrese la generatriz del cono: ");
        Generatriz = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la altura del cono: ");
        Altura = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el radio de giro del cono: ");
        Radio = Convert.ToDouble(Console.ReadLine());

        Area = Math.PI * Radio * (Radio + Generatriz);

        Volumen = 1 / 3.0 * Math.PI * Math.Pow(Radio, 2) * Altura;

        Console.WriteLine("El área del cono es: " + Area);
        Console.WriteLine("El volumen del cono es: " + Volumen);

        Console.ReadLine();
    }
}