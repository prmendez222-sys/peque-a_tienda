using System.Collections;

List<string> productos = new List<string>();
string opcion;

do
{
    Console.WriteLine("1. Agregar producto");
    Console.WriteLine("2. Mostrar productos");
    Console.WriteLine("3. Buscar producto");
    Console.WriteLine("4. Eliminar producto por nombre");
    Console.WriteLine("5. Eliminar producto por posición");
    Console.WriteLine("6. Ordenar productos");
    Console.WriteLine("7. Invertir lista");
    Console.WriteLine("8. Vaciar lista");
    Console.WriteLine("9. Mostrar cantidad de productos");
    Console.WriteLine("10. salir");
    Console.WriteLine();
    Console.Write("ingrese una opcion: ");
    opcion= Console.ReadLine();

    Console.Clear();

    switch (opcion)
    {
        case "1":
     
            string respuesta;

            do
            {
                Console.Write("ingrese nombre del Producto: ");
                productos.Add(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("producto ingresado correctamente");
                Console.WriteLine();
                do
                {
                    Console.Write("desea ingresar otro Prodructo (si/no): ");
                    respuesta = Console.ReadLine();
                    Console.Clear();
                } while (respuesta != "no" && respuesta != "si");
            } while (respuesta == "si");
            break;
        case "2":
            if (productos.Count == 0)
            {
                Console.WriteLine("no hay datos registrados");
                Console.WriteLine();
                Console.WriteLine("Presione Enter para continuar");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("ID         Nombre del Producto");
                foreach(string P in productos)
                {
                    Console.WriteLine($"{productos.IndexOf(P)}          {P}");
                }

                Console.WriteLine();
                Console.WriteLine("Presione Enter para continuar");
                Console.ReadLine();
            }
            break;
        case "3":
            Console.WriteLine("buscar producto");
            Console.WriteLine();
            Console.Write("ingrese nombre del Producto: ");
            string nombre= Console.ReadLine();
            nombre = nombre.ToLower()
                ;
            if (productos.Contains(nombre))
            {
                Console.WriteLine("se encontro el Producto");
                Console.WriteLine();
                Console.WriteLine("ID          Nombre Producto");
                foreach(String p in productos)
                {
                    if (p == nombre)
                    {
                        Console.WriteLine($"{productos.IndexOf(p)}          {productos[productos.IndexOf(p)]}");
                    }
                }
           
            }

            Console.WriteLine();
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();
            break;
    }

    Console.Clear();

} while (opcion != "10");