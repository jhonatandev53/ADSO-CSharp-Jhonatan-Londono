
List<Empleado> nomina =
[
    new EmpleadoPlanta("Ana Gómez", "1001", 3_200_000m, 6),
    new EmpleadoPlanta("Luis Pérez", "1002", 2_800_000m, 2),
    new EmpleadoPorHoras("Marta Ruiz", "1003", 170, 18_000m),
    new EmpleadoPorHoras("Jorge Díaz", "1004", 120, 18_000m),
    new Contratista("Sofía León", "1005", 4_000_000m)
];

Console.WriteLine("--- DETALLE DE NÓMINA ---");
foreach (var emp in nomina)
{
    Console.WriteLine(emp);
}


decimal totalNomina = nomina.Sum(e => e.CalcularSalario());
Console.WriteLine($"\nTotal Nómina: ${totalNomina:N0}");



Empleado mayorPago = nomina.MaxBy(e => e.CalcularSalario())!;
Console.WriteLine($"Mayor Pago: {mayorPago.Nombre} con ${mayorPago.CalcularSalario():N0}");

Console.WriteLine("\n--- TOTALES POR TIPO ---");
var totalesPorTipo = nomina
    .GroupBy(e => e.Tipo)
    .Select(g => new { Tipo = g.Key, Total = g.Sum(e => e.CalcularSalario()) });

foreach (var item in totalesPorTipo)
{
    Console.WriteLine($"{item.Tipo}: ${item.Total:N0}");
}

decimal totalBonos = nomina.OfType<IBonificable>().Sum(b => b.CalcularBono());
Console.WriteLine($"\nTotal de Bonos (Solo Planta): ${totalBonos:N0}");