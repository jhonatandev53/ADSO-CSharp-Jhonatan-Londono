// Crear una lista



List<string> compras = ["Arroz","Leche"];


compras.Add("Cafe"); // Permite agregar a la lista


compras.Remove("Cafe"); // Permite eliminar UN ELEMENTO


Console.WriteLine($"Tienes {compras.Count} elementos en la lista"); // Permite contar el numero de elementos

compras.Sort(); // Permite ordenar la lista

Console.WriteLine(string.Join(", ", compras)); // Permite mostrar la lista










// DICCIONARIOS

Console.WriteLine("===========================================");

Dictionary<string, string> agenda = new(StringComparer.OrdinalIgnoreCase);


agenda["Ana"] = "28929293";
agenda["angel"] = "33930293";

if (agenda.TryGetValue("ana", out string? telefono))
{
    Console.WriteLine($"Ana: {telefono}");

}

foreach (var (nombre, tell) in agenda)

{

    Console.WriteLine($"{nombre}: {tell}");

}


Console.WriteLine("===========================================");


// DICCIONARIOS CON LISTAS ADENTRO

Dictionary<string, List<double>> notas = new Dictionary<string, List<double>>(StringComparer.OrdinalIgnoreCase);

notas["Miguel"] = [];
notas["Miguel"].Add(4.5);
notas["Miguel"].Add(3.5);
notas["Miguel"].Add(2.5);

foreach (var (nombre, nota) in notas)
{
    Console.WriteLine($"{nombre}: {string.Join(", ", nota)}");
}




Console.WriteLine("===========================================");

// EJERCICIOS CON METODOS DE LISTAS

List<int> numeros = [10, 54, 32, 67, 21, 89, 65, 90, 3, 4];

// pares
var pares = numeros.Where(n => n % 2 == 0).ToList();
Console.WriteLine(string.Join(", ", pares));

// top 3
var top3 = numeros.OrderByDescending(n => n).Take(3).ToList();
Console.WriteLine(string.Join(", ", top3));

// Promedio
Console.WriteLine($"El promedio es: {numeros.Average()}");


// Evaluar si hay algun numero mayor a 80
Console.WriteLine($"Hay algun numero mayor a 80? {numeros.Any(n => n > 80)}");



Console.WriteLine("===========================================");

// Record
List<producto> productos =
    [
        new ("Cuaderno", "Papeleria", 6500, 10),
        new ("lapiz", "Papeleria", 1500, 10),
        new ("Celular", "tecnologia", 1000500, 10),

    ];

var baratos = productos.Where(p => p.precio < 10000);
var masCaro = productos.MaxBy(p => p.precio);
var masCaro1 = productos.Max(p => p.precio);
decimal valorInventario = productos.Sum(p => p.precio * p.cantidad);

Console.WriteLine($"El producto mas caro {masCaro}");
Console.WriteLine($"el producto mas barato {string.Join("?n", baratos)}");
Console.WriteLine($"el valor del inventario es {valorInventario}");


var porCategoria = productos
    .GroupBy(p => p.categoria)
    .Select(g => new { categoria = g.Key, Unidades = g.Sum(p => p.cantidad) });

foreach (var c in porCategoria)
{
    Console.WriteLine($"{c.categoria,-12} {c.Unidades} unidades");
}

record producto(string nombre, string categoria, decimal precio, int cantidad);