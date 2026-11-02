public class ProcesadorPagos
{
    public void Cobrar(IMetodoPago metodoPago, decimal monto)
    {
        Console.WriteLine($"\n--- Iniciando cobro con {metodoPago.Nombre} ---");

       
        if (!metodoPago.Validar(monto))
        {
            Console.WriteLine($"[DENEGADO] El monto de ${monto:N0} no cumple con las políticas de validación de {metodoPago.Nombre}.");
            return;
        }

        
        decimal comision = metodoPago.CalcularComision(monto);
        decimal totalPagar = monto + comision;

        Console.WriteLine($"Monto base: ${monto:N0}");
        Console.WriteLine($"Comisión aplicada: ${comision:N0}");
        Console.WriteLine($"Total debitado al cliente: ${totalPagar:N0}");
        Console.WriteLine("[APROBADO] Transacción completada con éxito.");
    }

    public void Devolver(IMetodoPago metodoPago, decimal monto)
    {
        Console.WriteLine($"\n--- Solicitando devolución con {metodoPago.Nombre} ---");

        
        if (metodoPago is IReembolsable metodoReembolsable)
        {
            metodoReembolsable.Reembolsar(monto);
        }
        else
        {
            Console.WriteLine($"[BLOQUEADO] El método '{metodoPago.Nombre}' no implementa IReembolsable; no se puede devolver el dinero.");
        }
    }
}