class Vehiculo
{
    protected string Placa { get; }

    public Vehiculo(string placa)
    {
        Placa = placa;
    }

    public string Describir()
    {
        return $"Vehiculo {Placa}";
    }
}

class Auto : Vehiculo
{
    private int puertas;

    public Auto(string placa, int puertas) : base(placa)
    {
        this.puertas = puertas;
    }

    public string Detalle()
    {
        return $"{Describir()} con {puertas} puertas";
    }
}

class Moto : Vehiculo
{
    public Moto(string placa) : base(placa)
    {
    }

    public string Detalle()
    {
        return $"{Describir()} de dos ruedas";
    }
}