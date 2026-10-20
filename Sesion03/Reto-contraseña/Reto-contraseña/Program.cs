
Principal();
static void Principal()
{
    string password;
    bool esFuerte = false;

    do
    {
        Console.Write("Contraseña: \n \n");
        password = Console.ReadLine();

        esFuerte = ValidarPassword(password);

        if (!esFuerte)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("La contraseña  no es segura \n \n");
            Console.ResetColor();
        }
    } while (!esFuerte);

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Contraseña correcta y segura \n \n");
    Console.ResetColor();
    
}

static bool ValidarPassword (string clave)
{

    string[] nombreReglas =
    {
        "Mínimo 8 caracteres",
        "Una mayúscula",
        "Una minúscula",
        "Un número",
        "Un carácter especial",
        "Sin espacios"
    };

    bool[] estadosReglas = new bool[6];

    estadosReglas[0] = clave.Length >= 8;

    bool tieneMayuscula = false;
    bool tieneMinuscula = false;
    bool tieneNumero = false;
    bool tieneEspecial = false;
    bool tieneEspacios = false;

    foreach (char c in clave)
    {
        if (char.IsUpper(c)) tieneMayuscula = true;
        if (char.IsLower(c)) tieneMinuscula = true;
        if (char.IsDigit(c)) tieneNumero = true;
        if (char.IsPunctuation(c) || char.IsSymbol(c)) tieneEspecial = true;
        if (char.IsWhiteSpace(c)) tieneEspacios = true;
    }

    estadosReglas[1] = tieneMayuscula;
    estadosReglas[2] = tieneMinuscula;
    estadosReglas[3] = tieneNumero;
    estadosReglas[4] = tieneEspecial;
    estadosReglas[5] = !tieneEspacios;

    int aciertos = 0;

    for (int i = 0; i < estadosReglas.Length; i++)
    {
        if (estadosReglas[i])
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" _/ {nombreReglas[i]}");
            Console.ResetColor();
            aciertos ++;
        }

        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($" X {nombreReglas[i]}");
            Console.ResetColor();
        }
            
    }

    string nivel = "";

    if (aciertos == 6)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        nivel = "Fuerte";
        Console.ResetColor();
    }
    else if (aciertos == 4 || aciertos == 5)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        nivel = "Medio";
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        nivel = "Debil";
        Console.ResetColor();
    }


    Console.WriteLine($"Nivel {nivel} ({aciertos}/6 acertadas) \n \n");

    return aciertos == 6;

}