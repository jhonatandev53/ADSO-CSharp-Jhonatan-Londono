// Generador de usuarios 

static string GeneradorDeUsuarios(string nombreCompleto, string documento)
{
    string limpio = nombreCompleto.ToLower()
        .Replace("á", "a")
        .Replace("é", "e")
        .Replace("í", "i")
        .Replace("ó", "o")
        .Replace("ú", "u");

    string[] palabras = limpio.Split(' ');

    char primeraLetra = palabras[0][0];

    string primerApellido = "";
    if (palabras.Length == 4)
    {
        primerApellido = palabras[2];
    }

    else if (palabras.Length == 3)
    {
        primerApellido = palabras[1];
    }

    string ultimosDigitos = documento.Substring(documento.Length - 2);
    string usuarioFinal = primeraLetra + primerApellido + ultimosDigitos;

    return usuarioFinal;

}

Console.WriteLine(GeneradorDeUsuarios("Jhonatan Londoño Muñoz", "1023636043"));




// Analizador de frases

static void AnalizadorDeFrases(string frase)
{
    frase = frase.Trim();

    string[] palabras = frase.Split(' ');

    int totalPalbras = palabras.Length;
    Console.WriteLine($"La frase tiene ({totalPalbras}) palbras");

    System.Text.StringBuilder  fraseInvertida = new System.Text.StringBuilder();

    for (int i= palabras.Length - 1; i >= 0; i--)
    {
        fraseInvertida.Append(palabras[i]);
    }

    Console.WriteLine($"Frase con palabras en orden inverso: {fraseInvertida.ToString()}");
}

AnalizadorDeFrases(" Hola como estas amigo ");