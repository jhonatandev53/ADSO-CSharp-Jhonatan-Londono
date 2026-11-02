public class PagoBilletera : IMetodoPago, IReembolsable
{
    public string Nombre => "Billetera Digital";
    public string Celular { get; }

    public PagoBilletera(string celular)
    {
        Celular = celular;
    }

    public decimal CalcularComision(decimal monto)
    {
        return monto * 0.01m;
    }

    public bool Validar(decimal monto)
    {
        
        return monto > 0 && monto <= 2_000_000m;
    }

    public void Reembolsar(decimal monto)
    {
        Console.WriteLine($"[ÉXITO] Reembolso de ${monto:N0} enviado a la billetera asociada al cel: {Celular}.");
    }
}