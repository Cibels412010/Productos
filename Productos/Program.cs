

using Productos.Negocio;

Pack pack1 = new Pack();
Pack pack2 = new Pack();

pack1.Nombre = "Albondigas";
pack1.Precio = 35;
pack1.Cantidad = 8;

pack2.Nombre = "Fideos";
pack2.Precio = 40;
pack2.Cantidad = 5;

Suelto suelto1 = new Suelto();
Suelto suelto2 = new Suelto();

suelto1.Nombre = "Papitas";
suelto1.Precio = 20;
suelto1.Medida = 200;

suelto2.Nombre = "tutucas";
suelto2.Precio = 10;
suelto2.Medida = 100;


//prueba
Console.WriteLine("El primer pack es de: " + pack1.Nombre + "\nEl Precio total es de: " + pack1.CalcularPrecio());
Console.WriteLine("\nEl segundo pack es de: " + pack2.Nombre + "\nEl Precio total es de: " + pack2.CalcularPrecio());
Console.WriteLine("\nEl primer suelto es de: " + suelto1.Nombre + "\nEl Precio total es de: " + suelto1.CalcularPrecio());
Console.WriteLine("\nEl segundo suelto es de: " + suelto2.Nombre + "\nEl Precio total es de: " + suelto2.CalcularPrecio());

//arrray de productos

Producto[] productos = [pack1, pack2, suelto1, suelto2]; // o {pack, suelto}
double TotalGastado = 0;

foreach (Producto p in productos)
{
    p.CalcularPrecio();
    TotalGastado += p.CalcularPrecio();
}

Console.WriteLine("\nEl total gastado en la compra es de: " + TotalGastado);
