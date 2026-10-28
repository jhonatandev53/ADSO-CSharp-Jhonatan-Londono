using System;

public class Producto
{
    private string codigo;
    public string Codigo
    {
        get => codigo;
        private set => codigo = value?.ToUpper().Trim() ?? throw new ArgumentNullException(nameof(value));
    }

    private string nombre;
    public string Nombre
    {
        get => nombre;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El nombre no puede estar vacío.");
            nombre = value;
        }
    }

    private decimal precio;
    public decimal Precio
    {
        get => precio;
        private set
        {
            if (value <= 0)
                throw new ArgumentException("El precio debe ser mayor a cero.");
            precio = value;
        }
    }

    private int stock;
    public int Stock
    {
        get => stock;
        private set
        {
            if (value < 0)
                throw new ArgumentException("El stock no puede ser negativo.");
            stock = value;
        }
    }

    public Producto(string codigo, string nombre, decimal precio, int stock)
    {
        Codigo = codigo;
        Nombre = nombre;
        Precio = precio;
        Stock = stock;
    }

    public void AgregarStock(int cantidad)
    {
        if (cantidad <= 0) throw new ArgumentException("La cantidad a agregar debe ser mayor a cero.");
        Stock += cantidad;
    }

    public bool Vender(int cantidad)
    {
        if (cantidad <= 0 || cantidad > Stock) return false;
        Stock -= cantidad;
        return true;
    }
}