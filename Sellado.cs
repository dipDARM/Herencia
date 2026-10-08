class Empleado
{
    public string Nombre { get; }
    public decimal Salario { get; }

    public Empleado(string nombre, decimal salario)
    {
        Nombre = nombre;
        Salario = salario;
    }
}

sealed class Gerente : Empleado
{
    private decimal bono;

    public Gerente(string nombre, decimal salario, decimal bono)
        : base(nombre, salario)
    {
        this.bono = bono;
    }

    public decimal Total()
    {
        return Salario + bono;
    }
}