using Inventario.Datos;
using Inventario.Modelos;
using Inventario.Servicios;

var servicio = new ServicioInventario(new RepositorioMemoria());
bool salir = false;

while (!salir)
{
    Console.Clear();
    Console.WriteLine("=== SISTEMA DE GESTIÓN DE INVENTARIO ===");
    Console.WriteLine("1. Registrar nuevo producto");
    Console.WriteLine("2. Agregar stock");
    Console.WriteLine("3. Vender producto");
    Console.WriteLine("4. Ver todos los productos");
    Console.WriteLine("5. Ver productos con stock bajo (< 5)");
    Console.WriteLine("6. Buscar productos por texto");
    Console.WriteLine("7. Eliminar producto");
    Console.WriteLine("8. Salir");
    Console.Write("\nSeleccione una opción: ");

    string opcion = Console.ReadLine() ?? "";

    try
    {
        switch (opcion)
        {
            case "1":
                RegistrarProducto(servicio);
                break;
            case "2":
                AgregarStockUI(servicio);
                break;
            case "3":
                VenderProductoUI(servicio);
                break;
            case "4":
                MostrarLista("--- TODOS LOS PRODUCTOS ---", servicio.Listar());
                break;
            case "5":
                MostrarLista("--- PRODUCTOS EN STOCK BAJO ---", servicio.ObtenerStockBajo());
                break;
            case "6":
                BuscarTextoUI(servicio);
                break;
            case "7":
                EliminarProductoUI(servicio);
                break;
            case "8":
                salir = true;
                Console.WriteLine("¡Gracias por usar el sistema!");
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
    catch (StockInsuficienteException ex)
    {
        Console.WriteLine($"\n[ERROR DE STOCK] {ex.Message}");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"\n[DATOS INVÁLIDOS] {ex.Message}");
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine($"\n[OPERACIÓN NO PERMITIDA] {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\n[ERROR INESPERADO] {ex.Message}");
    }

    if (!salir)
    {
        Console.WriteLine("\nPresione ENTER para continuar...");
        Console.ReadLine();
    }
}

static void RegistrarProducto(ServicioInventario servicio)
{
    Console.Write("Código: ");
    string codigo = Console.ReadLine() ?? "";
    Console.Write("Nombre: ");
    string nombre = Console.ReadLine() ?? "";
    Console.Write("Precio: ");
    decimal precio = decimal.Parse(Console.ReadLine() ?? "0");
    Console.Write("Stock inicial: ");
    int stock = int.Parse(Console.ReadLine() ?? "0");

    servicio.Agregar(new Producto(codigo, nombre, precio, stock));
    Console.WriteLine("✅ Producto registrado exitosamente.");
}

static void AgregarStockUI(ServicioInventario servicio)
{
    Console.Write("Código del producto: ");
    string codigo = Console.ReadLine() ?? "";
    Console.Write("Cantidad a agregar: ");
    int cantidad = int.Parse(Console.ReadLine() ?? "0");

    servicio.AgregarStock(codigo, cantidad);
    Console.WriteLine("✅ Stock actualizado.");
}

static void VenderProductoUI(ServicioInventario servicio)
{
    Console.Write("Código del producto: ");
    string codigo = Console.ReadLine() ?? "";
    Console.Write("Cantidad a vender: ");
    int cantidad = int.Parse(Console.ReadLine() ?? "0");

    servicio.Vender(codigo, cantidad);
    Console.WriteLine("✅ Venta realizada con éxito.");
}

static void BuscarTextoUI(ServicioInventario servicio)
{
    Console.Write("Ingrese término a buscar (código o nombre): ");
    string texto = Console.ReadLine() ?? "";
    MostrarLista($"--- RESULTADOS PARA '{texto}' ---", servicio.BuscarPorTexto(texto));
}

static void EliminarProductoUI(ServicioInventario servicio)
{
    Console.Write("Código del producto a eliminar: ");
    string codigo = Console.ReadLine() ?? "";

    Console.Write($"¿Está seguro que desea eliminar el producto '{codigo}'? (s/n): ");
    string confirmacion = (Console.ReadLine() ?? "").ToLower();

    if (confirmacion == "s")
    {
        servicio.Eliminar(codigo);
        Console.WriteLine("✅ Producto eliminado exitosamente.");
    }
    else
    {
        Console.WriteLine("Operación cancelada.");
    }
}

static void MostrarLista(string titulo, List<Producto> productos)
{
    Console.WriteLine($"\n{titulo}");
    if (productos.Count == 0)
    {
        Console.WriteLine("No se encontraron registros.");
        return;
    }

    foreach (var p in productos)
    {
        Console.WriteLine($"• [{p.Codigo}] {p.Nombre} | Precio: ${p.Precio} | Stock: {p.Stock}");
    }
}