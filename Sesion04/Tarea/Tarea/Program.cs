List<Venta> ventas =
[
    new("Portátil", "Medellín", 2, 2_800_000m),
    new("Mouse", "Bogotá", 10, 45_000m),
    new("Teclado", "Cali", 5, 120_000m),
    new("Monitor", "Medellín", 3, 750_000m),
    new("Mouse", "Medellín", 8, 45_000m),
    new("Portátil", "Bogotá", 1, 2_800_000m),
    new("Diadema", "Cali", 6, 180_000m),
    new("Monitor", "Bogotá", 2, 750_000m),
    new("Teclado", "Medellín", 4, 120_000m),
    new("Diadema", "Bogotá", 3, 180_000m),
    new("Portátil", "Cali", 2, 2_800_000m),
    new("Mouse", "Cali", 12, 45_000m)
];

decimal totalVendido = ventas.Sum(p => p.Cantidad * p.PrecioUnitario);

decimal promedioPorVenta = ventas.Average(p => p.Cantidad * p.PrecioUnitario);

var ventasPorCiudad = ventas
    .GroupBy(p => p.Ciudad)
    .Select(g => new { Ciudad = g.Key, TotalIngresos = g.Sum(x => x.Cantidad * x.PrecioUnitario) })
    .OrderByDescending(x => x.TotalIngresos);

var top3Productos = ventas
    .GroupBy(p => p.Producto)
    .Select(g => new { Producto = g.Key, TotalIngresos = g.Sum(x => x.Cantidad * x.PrecioUnitario) })
    .OrderByDescending(x => x.TotalIngresos)
    .Take(3);

var productoMasVendido = ventas
    .GroupBy(p => p.Producto)
    .Select(g => new { Producto = g.Key, TotalUnidades = g.Sum(x => x.Cantidad) })
    .OrderByDescending(x => x.TotalUnidades)
    .FirstOrDefault();

record Venta(string Producto, string Ciudad, int Cantidad, decimal PrecioUnitario);