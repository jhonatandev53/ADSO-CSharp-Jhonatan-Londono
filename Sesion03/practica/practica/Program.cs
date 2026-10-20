// Procedimiento (Tiene la impresion adentro)

static void MostrarTitulo(string titulo)
{
    Console.WriteLine($"Tu titulo es: {titulo}");
}

MostrarTitulo("principito");


// Función (Tiene que tener un return)

static int Sumar(int a, int b)
{
    return a + b;
}

Console.WriteLine($"LA suma es: {Sumar(5,5)}");


// Sobrecargas y parametros opcionales (No toma los parametros ya que son opcionales)

static void Saludar(string nombre, int edad = 18)
{
    Console.WriteLine($"Nombre: {nombre} Edad: {edad}");
}

Saludar("Juan"); // Si no le mandamos la edad no pasa nada



// Funcion que lee un entero 
static int LeerEntero()
{
    Console.WriteLine("Digite un numero");
    int valor;

    while (!int.TryParse(Console.ReadLine(), out valor))
    {
        Console.WriteLine("No es un entero, intentelo de nuevo");
    }
    return valor;
}

Console.WriteLine(LeerEntero());




// Funcion que lee un decimal
static decimal leerDecimal(string mensaje)
{
    Console.Write(mensaje);
    decimal valor;
    while (!decimal.TryParse(Console.ReadLine(), out valor))
    {
        Console.WriteLine("Valor no valido, intenta de nuevo \n Digita un numero decimal : ");
    }
    return valor;
}

Console.WriteLine(leerDecimal("Digita un numero decimal: "));






// ================================================================================================================================================================================
// ================================================================================================================================================================================

//                                                                      ARREGLOS Y CADENAS

// ================================================================================================================================================================================
// ================================================================================================================================================================================


decimal[] notas = new decimal[5]; // D;Eclaramos el arreglo (de 0 a 4)

for (int i = 0 ; i <= notas.Length; i++)
{
    notas[i] = leerDecimal($"Nota: {i + 1}");
    
}

Console.WriteLine(string.Join(" | ", notas));
