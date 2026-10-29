
class Program
{
    static void Main(string[] args)
    {
        // 1. Creación de las dos cuentas
        CuentaBancaria cuenta1 = new CuentaBancaria("Carlos Pérez", "1001-A", 500m);
        CuentaBancaria cuenta2 = new CuentaBancaria("María Gómez", "2002-B", 200m);
        

        Console.WriteLine("=== ESTADO INICIAL ===");
        Console.WriteLine($"{cuenta1.Titular} tiene un saldo de: ${cuenta1.Saldo}");
        Console.WriteLine($"{cuenta2.Titular} tiene un saldo de: ${cuenta2.Saldo}");
        Console.WriteLine();

        // 2. Prueba de Depósito
        Console.WriteLine("=== 1. PRUEBA DE DEPÓSITO ===");
        bool depositoExitoso = cuenta1.Depositar(150m);
        Console.WriteLine($"¿Depósito de $150 a {cuenta1.Titular} realizado?: {depositoExitoso}");
        Console.WriteLine($"Nuevo saldo de {cuenta1.Titular}: ${cuenta1.Saldo}");
        Console.WriteLine();

        // 3. Prueba de Retiro Rechazado (monto mayor al saldo)
        Console.WriteLine("=== 2. PRUEBA DE RETIRO RECHAZADO ===");
        bool retiroExitoso = cuenta1.Retirar(1000m); // Intenta sacar 1000 teníendo solo 650
        Console.WriteLine($"¿Retiro de $1000 de {cuenta1.Titular} realizado?: {retiroExitoso}");
        Console.WriteLine($"Saldo de {cuenta1.Titular} (sin cambios): ${cuenta1.Saldo}");
        Console.WriteLine();

        // 4. Prueba de Transferencia
        Console.WriteLine("=== 3. PRUEBA DE TRANSFERENCIA ===");
        bool transferenciaExitosa = cuenta1.Transferir(cuenta2, 200m);
        Console.WriteLine($"¿Transferencia de $200 de {cuenta1.Titular} a {cuenta2.Titular} exitosa?: {transferenciaExitosa}");
        Console.WriteLine();

        // Estado Final
        Console.WriteLine("=== ESTADO FINAL DE LAS CUENTAS ===");
        Console.WriteLine($"{cuenta1.Titular} (Cuenta {cuenta1.Numero}) - Saldo final: ${cuenta1.Saldo}");
        Console.WriteLine($"{cuenta2.Titular} (Cuenta {cuenta2.Numero}) - Saldo final: ${cuenta2.Saldo}");
    }
}