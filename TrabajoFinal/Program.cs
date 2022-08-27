Console.WriteLine("Proyecto!");


List<book> libros = new List<book>();
List<book> ventas = new List<book>();

void Imprimir()
{
    Console.Clear();
    Console.WriteLine("Libros \n");

    foreach (var item in libros)
    {
        Console.WriteLine($"Nombre {item.Nombre} - Cantidad {item.Cantidad} - Precio {item.Precio} - Ubicacion {item.Ubicacion} ");
    }
    Console.WriteLine("\n");
}


void ShowMenu()
{
    Console.WriteLine("Menu \n");

    Console.WriteLine("1. Ingresar libros. ");
    Console.WriteLine("2. Mover libros de ubicación ");
    Console.WriteLine("3. Modificar libros. ");
    Console.WriteLine("4. Vender libros. ");
    Console.WriteLine("5. Generar archivo con listado de libros. ");
    Console.WriteLine("6. Generar factura de venta. ");
    Console.WriteLine("7. Generar archivo listado de Autores. ");
    Console.WriteLine("8. Generar listado de tipos. ");
    Console.WriteLine("9. Salir \n ");

    Console.Write("Seleccione una opcion: ");
}

bool activeSesion = true;

while (activeSesion)
{
    ShowMenu();
    var option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
            Console.Write("Nombre: ");
            var name = Console.ReadLine();
            Console.Write("Autor: ");
            var autor = Console.ReadLine();
            Console.Write("Tipo: ");
            var tipo = Console.ReadLine();
            Console.Write("Precio: ");
            var precio = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cantidad: ");
            var cantidad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ubicacion: ");
            var ubicación = Console.ReadLine();

            var newbook = new book
            {
                Autor = autor,
                Cantidad = cantidad,
                Nombre = name,
                Tipo = tipo,
                Precio = precio,
                Ubicacion = ubicación
            };

            libros.Add(newbook);

            break;

        case 2:
            Console.Clear();
            Console.WriteLine("Mover ubicación de libro: \n");

            Console.Write("Introduzca el nombre del libro: ");
            var moveName = Console.ReadLine();

            var moveBook = libros.FirstOrDefault(x => x.Nombre == moveName);

            if (moveBook == null)
            {
                Console.WriteLine("Este libro no existe \n");
                break;
            }

            Console.Write("Nueva ubicacion: ");
            var ubicacionNew = Console.ReadLine();

            foreach (var item in libros.Where(x => x.Nombre == moveName))
            {
                item.Ubicacion = ubicacionNew;
            }

            Console.Write($"el libro {moveName} ha sido movido de ubicacion \n");

            break;

        case 3:
            Console.Clear();
            Console.WriteLine("Actualizar libro: \n");

            Console.Write("Introduzca el nombre del libro: ");
            var updateName = Console.ReadLine();

            var updateBook = libros.FirstOrDefault(x => x.Nombre == updateName);

            if (updateBook == null)
            {
                Console.WriteLine("Este libro no existe \n");
                break;
            }

            Console.WriteLine("Favor inserte datos del libro \n");
            Console.Write("Nombre: ");
            var uname = Console.ReadLine();
            Console.Write("Autor: ");
            var uautor = Console.ReadLine();
            Console.Write("Tipo: ");
            var utipo = Console.ReadLine();
            Console.Write("Precio: ");
            var uprecio = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cantidad: ");
            var ucantidad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ubicacion: ");
            var uubicación = Console.ReadLine();

            foreach (var item in libros.Where(x => x.Nombre == updateName))
            {
                item.Nombre = uname;
                item.Ubicacion = uubicación;
                item.Tipo = utipo;
                item.Cantidad = ucantidad;
                item.Precio = uprecio;
                item.Autor = uautor;
            }

            Console.Write($"el libro {updateName} ha sido actualizado \n");

            break;

        case 4:
            Console.Clear();
            Console.WriteLine("Vender libro: \n");

            Console.Write("Introduzca el nombre del libro: ");
            var sellName = Console.ReadLine();

            var sellBook = libros.FirstOrDefault(x => x.Nombre == sellName);

            if (sellBook == null)
            {
                Console.WriteLine("Este libro no existe \n");
                break;
            }

            Console.Write("Cantidad de libros: ");
            var sellcantidad = Convert.ToInt32(Console.ReadLine());

            if (sellBook.Cantidad < sellcantidad)
            {
                Console.WriteLine("No tenemos disponibles esa cantidad de libros \n");
                break;
            }

            var soldBook = new book
            {
                Autor = sellBook.Autor,
                Cantidad = sellBook.Cantidad,
                Nombre = sellBook.Nombre,
                Tipo = sellBook.Tipo,
                Precio = sellBook.Precio,
                Ubicacion = sellBook.Ubicacion
            };
            
            soldBook.Cantidad = sellcantidad;

            ventas.Add(soldBook);

            foreach (var item in libros.Where(x => x.Nombre == sellName))
            {
                item.Cantidad = item.Cantidad - sellcantidad;
            }

            Console.WriteLine("Venta procesada \n");
            break;
        case 5:
            Imprimir();
            break;

        case 7:
            Imprimir();
            break;
        case 8:
            Imprimir();
            break;

        case 9:
            activeSesion = false;
            break;
    }
}
