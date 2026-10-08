using System;

class Program
{
    static void Main(string[] args)
    {

        Perro perro = new Perro("Rex", "Labrador");
        Console.WriteLine($"{perro.Nombre} ({perro.Raza})");

        Gerente gerente = new Gerente("Richard", 5000000m, 800000m);
        Console.WriteLine($"{gerente.Nombre}: {gerente.Total()}");

        Auto auto = new Auto("ABC123", 4);
        Moto moto = new Moto("XYZ987");

        Console.WriteLine(auto.Detalle());
        Console.WriteLine(moto.Detalle());
    }
}