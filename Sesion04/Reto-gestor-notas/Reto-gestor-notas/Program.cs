using System.Threading.Channels;

bool exit = false;

Dictionary<string, List<double>> notas = new Dictionary<string, List<double>>();
while (!exit)
{

    Menu();
    string opcion = Console.ReadLine();

    switch (opcion)
    {

        case "1": RegistrarAprendiz(); break;
        case "2": AgregarNota(); break;
        case "3": ListarTodos(); break;
        case "4": RankinPromedio(); break;
        case "5": MejorAprendizAprobados(); break;
        case "6": EliminarAprendiz(); break;
        case "7": ReportePorNivel(); break;
        case "8": exit = true; break;
        default: Console.WriteLine("Opción no valida"); break;

    }

}

void Menu()
{

    Console.WriteLine("==========================\n \n");
    Console.WriteLine("GESTOR DE NOTAS DE ESTUDIANTES \n \n");
    Console.WriteLine("========================== \n \n");
    Console.WriteLine(" 1 - Registrar Aprendiz \n 2 - Agregar nota ( 0 - 5) \n 3 - Listar todos\n 4 - Ranking por promedio \n 5 - Mejor aprendiz y aprobados \n 6 - Eliminar aprendiz \n 7 - Reporte por nivel \n 8 - Salir");

}
void RegistrarAprendiz ()
{
    Console.WriteLine("Ingrese el nombre del aprendiz: ");
    string nombre = Console.ReadLine().Trim();

    if (string.IsNullOrWhiteSpace(nombre))
    {
        Console.WriteLine("El nombre no puede estar vacio");
        return;
    }

    if (notas.ContainsKey(nombre)) {
        Console.WriteLine($"El aprendiz {nombre} ya esta registrado");
        return;
    }

    else
    {
        notas.Add(nombre, new List<double>());
        Console.WriteLine($"Aprendiz {nombre} registrado con exito");
    }
}

void AgregarNota ()
{
    Console.WriteLine("Ingrese el nombre del aprendiz");
    string nombre = Console.ReadLine().Trim();

    if (!notas.ContainsKey(nombre))
    {
        Console.WriteLine($"El aprendiz {nombre} no existe");
        return;
    }

    Console.WriteLine("Ingrese la nota (0 - 5)");
    if (double.TryParse(Console.ReadLine(), out double nota) && nota >= 0.0 && nota <= 5.0)
    {
        notas[nombre].Add(nota);
        Console.WriteLine($"Nota agregada ({nota}) a {nombre}");
    }
    else
    {
        Console.WriteLine("Nota invalida debe ser un numero entre 0 y 5");
    }


}

void ListarTodos ()
{

    if (notas.Count == 0)
    {
        Console.WriteLine("No hay aprendices registrados");
        return;
    }

    Console.WriteLine("LISTADO GENERAL DE APRENDICES");
    foreach (var s in notas)
    {
        string nombre = s.Key;
        List<double> listaNotas = s.Value;
        int cantidadNotas = listaNotas.Count;

        double promedio = cantidadNotas > 0 ? listaNotas.Average() : 0.0;
        char juicio = promedio >= 3.5 ? 'A' : 'D';

        Console.WriteLine($"{nombre,-15} · {cantidadNotas} notas · Promedio {promedio:F1} · Juicio {juicio}\n");
    }

}

void RankinPromedio ()
{
    var rankin = notas.Where(a => a.Value.Count > 0).OrderByDescending(a => a.Value.Average());

    if (!rankin.Any())
    {
        Console.WriteLine("No hay aprendices con notas");
        return;
    }

    Console.WriteLine("RANKIN MAYOR A MENOR PROMEDIO");
    int puesto = 1;

    foreach(var a in rankin)
    {
        double promedio = a.Value.Average();
        Console.WriteLine($"{puesto++}. {a.Key,-15} · Promedio: {promedio:F2}");
    }
}

void MejorAprendizAprobados()
{

    var conNotas = notas.Where(a => a.Value.Count > 0);

    if (!conNotas.Any())
    {
        Console.WriteLine("No hay notas para mostrar");
        return;
    }

    var mejor = conNotas.OrderByDescending(a => a.Value.Average()).First();

    int cantidadAprobados = conNotas.Count(a => a.Value.Average() >= 3.5);

    Console.WriteLine($"\n Mejor aprendiz: {mejor.Key} con un promedio de {mejor.Value.Average():F2}");
    Console.WriteLine($"Total de aprendices que aprobaron (>= 3.5): {cantidadAprobados}");

}

void EliminarAprendiz()
{

    Console.WriteLine("Ingrese el nombre del aprendiz a eliminar");
    string nombre = Console.ReadLine().Trim();


    if (notas.Remove(nombre)){
        Console.WriteLine($"Aprendiz {nombre} eliminado correctamente");
    }
    else
    {
        Console.WriteLine("Aprendiz no encontrado");
    }

}

void ReportePorNivel()
{

    var contarNotas = notas.Where(a => a.Value.Count > 0);

    if (!contarNotas.Any())
    {
        Console.WriteLine("No hay aprendices para mostrar");
        return;
    }

    var agrupados = contarNotas.GroupBy(a =>
    {
        double prom = a.Value.Average();
        if (prom >= 4.5) return "Excelente";
        if (prom >= 4.0) return "Sobresaliente";
        if (prom >= 3.5) return "Aceptable";
        return "Deficiente";
    });


    Console.WriteLine("REPORTE POR NIVEL");
    foreach (var grupo in agrupados)
    {
        Console.WriteLine($"Nivel [{grupo.Key}]");
        foreach (var aprendiz in grupo)
        {
            Console.WriteLine($"  - {aprendiz.Key,-15} (Promedio: {aprendiz.Value.Average():F2})");
        }
    }
}