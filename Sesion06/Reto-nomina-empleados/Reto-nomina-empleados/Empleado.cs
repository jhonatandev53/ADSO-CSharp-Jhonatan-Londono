public interface IBonificable
{
    decimal CalcularBono();
}

public abstract class Empleado
{
    public string Nombre { get; }
    public string Documento { get; }

    public virtual string Tipo => "Empleado";

    protected Empleado(string nombre, string documento)
    {
        Nombre = nombre;
        Documento = documento;
    }

    public abstract decimal CalcularSalario();

    public override string ToString() => $"{Nombre} ({Documento}) - {Tipo}: ${CalcularSalario():N0}";
}



public class EmpleadoPlanta : Empleado, IBonificable
{
    public decimal SalarioMensual { get; }
    public int Antiguedad { get; }
    public override string Tipo => "Planta";

    public EmpleadoPlanta(string nombre, string documento, decimal salarioMensual, int antiguedad)
        : base(nombre, documento)
    {
        SalarioMensual = salarioMensual;
        Antiguedad = antiguedad;
    }

    public override decimal CalcularSalario()
    {
        return SalarioMensual + CalcularBono();
    }

    
    public decimal CalcularBono()
    {
        return Antiguedad >= 5 ? SalarioMensual * 0.05m : 0m;
    }
}

public class EmpleadoPorHoras : Empleado
{
    public int Horas { get; }
    public decimal ValorHora { get; }
    public override string Tipo => "Por Horas";

    public EmpleadoPorHoras(string nombre, string documento, int horas, decimal valorHora)
        : base(nombre, documento)
    {
        Horas = horas;
        ValorHora = valorHora;
    }

    public override decimal CalcularSalario()
    {
        if (Horas <= 160)
        {
            return Horas * ValorHora;
        }

        int horasNormales = 160;
        int horasExtra = Horas - 160;

        return (horasNormales * ValorHora) + (horasExtra * ValorHora * 1.5m);
    }
}

public class Contratista : Empleado
{
    public decimal ValorContrato { get; }
    public override string Tipo => "Contratista";

    public Contratista(string nombre, string documento, decimal valorContrato)
        : base(nombre, documento)
    {
        ValorContrato = valorContrato;
    }

    public override decimal CalcularSalario()
    {
        return ValorContrato * 0.90m; 
    }
}