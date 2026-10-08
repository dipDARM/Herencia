class Animal
{
    public string Nombre { get; }

    public Animal(string nombre)
    {
        Nombre = nombre;
    }
}

class Perro : Animal
{
    public string Raza { get; }

    public Perro(string nombre, string raza) : base(nombre)
    {
        Raza = raza;
    }
}