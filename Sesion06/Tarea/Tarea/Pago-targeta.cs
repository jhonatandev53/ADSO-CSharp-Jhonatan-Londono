public class PagoTarjeta : IMetodoPago, IReembolsable
{
    public string Nombre => "Tarjeta de Crédito";
    public string NumeroTarjeta { get; }

    public PagoTarjeta(string numeroTarjeta)
    {
        NumeroTarjeta = numeroTarjeta;
    }

    public decimal CalcularComision(decimal monto)
    {
        return monto * 0.03m; 
    }

    public bool Validar(decimal monto)
    {
      
        return monto > 0 && !string.IsNullOrEmpty(NumeroTarjeta) && NumeroTarjeta.Length == 16;
    }

    public void Reembolsar(decimal monto)
    {
        Console.WriteLine($"[ÉXITO] Reembolso de ${monto:N0} procesado a la tarjeta terminada en {NumeroTarjeta[^4..]}.");
    }
}