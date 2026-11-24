namespace Inventario.Modelos;

public class Categoria
{
    public int Id { get; set; }
    public string Nombre { get; set; } = "";
    public List<Producto> Productos { get; set; } = [];
    public override string ToString() => Nombre;   // así se ve en la grilla
}