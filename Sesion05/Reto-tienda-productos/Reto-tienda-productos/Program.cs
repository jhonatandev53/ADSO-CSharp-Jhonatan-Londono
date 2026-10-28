

class Program
{
    static int contadorFactura = 1;

    static void Main(string[] args)
    {
        // 3 productos precargados
        List<Producto> inventario = new List<Producto>
        {
            new Producto("P001", "Laptop Gamer", 3500000m, 5),
            new Producto("P002", "Mouse Inalámbrico", 75000m, 20),
            new Producto("P003", "Teclado Mecánico", 250000m, 10)
        };

        List<LineaVenta> carrito = new List<LineaVenta>();
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\n=== MENÚ PRINCIPAL ===");
            Console.WriteLine("1. Registrar producto");
            Console.WriteLine("2. Agregar stock");
            Console.WriteLine("3. Vender producto (Añadir al carrito)");
            Console.WriteLine("4. Ver carrito y total");
            Console.WriteLine("5. Ver inventario");
            Console.WriteLine("6. Confirmar compra (Generar Factura)");
            Console.WriteLine("7. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();
            Console.WriteLine();

            try
            {
                switch (opcion)
                {
                    case "1":
                        Console.Write("Código: ");
                        string cod = Console.ReadLine();

                        if (inventario.Any(p => p.Codigo == cod.ToUpper()))
                        {
                            Console.WriteLine("⚠️ Error: Ya existe un producto con ese código.");
                            break;
                        }

                        Console.Write("Nombre: ");
                        string nom = Console.ReadLine();
                        Console.Write("Precio: ");
                        decimal prec = decimal.Parse(Console.ReadLine());
                        Console.Write("Stock inicial: ");
                        int stk = int.Parse(Console.ReadLine());

                        inventario.Add(new Producto(cod, nom, prec, stk));
                        Console.WriteLine("✅ Producto registrado exitosamente.");
                        break;

                    case "2":
                        Console.Write("Ingrese el código del producto: ");
                        string codStock = Console.ReadLine();
                        Producto prodStock = inventario.FirstOrDefault(p => p.Codigo == codStock.ToUpper());

                        if (prodStock == null)
                        {
                            Console.WriteLine("❌ El producto no existe.");
                            break;
                        }

                        Console.Write("Cantidad a agregar: ");
                        int cantAgregada = int.Parse(Console.ReadLine());
                        prodStock.AgregarStock(cantAgregada);
                        Console.WriteLine("✅ Stock actualizado con éxito.");
                        break;

                    case "3":
                        Console.Write("Ingrese el código del producto a vender: ");
                        string codVenta = Console.ReadLine();
                        Producto prodVenta = inventario.FirstOrDefault(p => p.Codigo == codVenta.ToUpper());

                        if (prodVenta == null)
                        {
                            Console.WriteLine("❌ El producto no existe.");
                            break;
                        }

                        Console.Write($"Stock disponible ({prodVenta.Stock}). Cantidad a vender: ");
                        int cantVenta = int.Parse(Console.ReadLine());

                        if (prodVenta.Vender(cantVenta))
                        {
                            decimal subtotal = cantVenta * prodVenta.Precio;
                            carrito.Add(new LineaVenta(prodVenta.Codigo, prodVenta.Nombre, cantVenta, subtotal));
                            Console.WriteLine("✅ Producto agregado al carrito.");
                        }
                        else
                        {
                            Console.WriteLine("❌ Stock insuficiente o cantidad inválida.");
                        }
                        break;

                    case "4":
                        Console.WriteLine("--- CARRITO DE COMPRAS ---");
                        if (carrito.Count == 0)
                        {
                            Console.WriteLine("El carrito está vacío.");
                        }
                        else
                        {
                            foreach (var item in carrito)
                            {
                                Console.WriteLine($"[{item.Codigo}] {item.Nombre} - Cant: {item.Cantidad} - Subtotal: ${item.Subtotal:N2}");
                            }
                            decimal totalCarrito = carrito.Sum(l => l.Subtotal);
                            Console.WriteLine($"---------------------------");
                            Console.WriteLine($"TOTAL A PAGAR: ${totalCarrito:N2}");
                        }
                        break;

                    case "5":
                        Console.WriteLine("--- INVENTARIO ACTUAL ---");
                        foreach (var p in inventario)
                        {
                            Console.WriteLine($"[{p.Codigo}] {p.Nombre} | Precio: ${p.Precio:N2} | Stock: {p.Stock}");
                        }
                        break;

                    case "6":
                        if (carrito.Count == 0)
                        {
                            Console.WriteLine("⚠️ No hay productos en el carrito para facturar.");
                            break;
                        }

                        var factura = new Factura(contadorFactura++, DateTime.Now, new List<LineaVenta>(carrito), carrito.Sum(l => l.Subtotal));

                        Console.WriteLine("\n==================================");
                        Console.WriteLine("           RECIBO DE VENTA        ");
                        Console.WriteLine("==================================");
                        Console.WriteLine($"Factura N°: {factura.Numero}");
                        Console.WriteLine($"Fecha: {factura.Fecha}");
                        Console.WriteLine("----------------------------------");
                        foreach (var linea in factura.Lineas)
                        {
                            Console.WriteLine($"{linea.Nombre} (x{linea.Cantidad}) - ${linea.Subtotal:N2}");
                        }
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine($"TOTAL GENERAL: ${factura.Total:N2}");
                        Console.WriteLine("==================================\n");

                        carrito.Clear();
                        break;

                    case "7":
                        salir = true;
                        Console.WriteLine("¡Hasta luego!");
                        break;

                    default:
                        Console.WriteLine("⚠️ Opción inválida.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n⚠️ Error en los datos ingresados: {ex.Message}\n");
            }

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}