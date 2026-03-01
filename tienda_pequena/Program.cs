using System.Collections;

List<string> productos = new List<string>();
List<int> Id=new List<int>();
string opcion;
int cont = 0;

do
{
    Console.WriteLine("1. Agregar producto");
    Console.WriteLine("2. Mostrar productos");
    Console.WriteLine("3. Buscar producto");
    Console.WriteLine("4. Eliminar producto por nombre");
    Console.WriteLine("5. Eliminar producto por ID");
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
                Id.Add(cont++);
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
            }
            else
            {
                Console.WriteLine("ID         Nombre del Producto");
                for(int i=0; i<productos.Count; i++)
                {
                    Console.WriteLine($"{Id[i]}          {productos[i]}");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();
            break;
        case "3":
            if (productos.Count == 0)
            {
                Console.WriteLine("no hay datos registrados");
            }
            else
            {
                Console.WriteLine("buscar producto");
                Console.WriteLine();
                Console.Write("ingrese nombre del Producto: ");
                string nombre = Console.ReadLine();
                nombre = nombre.ToLower()
                    ;
                if (productos.Contains(nombre))
                {
                    Console.WriteLine();
                    Console.WriteLine("se encontraron los siguientes Productos");
                    Console.WriteLine();
                    Console.WriteLine("ID          Nombre Producto");
                    for (int x = 0; x < productos.Count; x++)
                    {
                        if (productos[x] == nombre)
                        {
                            Console.WriteLine($"{Id[x]}           {productos[x]}");
                        }
                    }
                }
                else
                {
                    if (productos.Exists(n => n.StartsWith(nombre[0])))
                    {
                        Console.WriteLine();
                        string coicidencia = productos.Find(c => c.StartsWith(nombre[0]));

                        Console.WriteLine($"tal ves quisiste decir? {coicidencia}");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Producto no encontrado o no existente");
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();
            break;
        case "4":

            if (productos.Count == 0)
            {
                Console.WriteLine("no hay datos registrados");
            }
            else
            {
                Console.WriteLine("se eliminara la primera coicidencia del producto");
                Console.WriteLine();
                Console.Write("ingrese nombre del producto: ");
                string nombreP = Console.ReadLine();
                nombreP = nombreP.ToLower();

                if (productos.Contains(nombreP))
                {
                    productos.Remove(nombreP);

                    Console.WriteLine();
                    Console.WriteLine("Producto eliminado con exito");

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Producto no existente");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();
            break;
        case "5":
            if(productos.Count == 0)
            {
                Console.WriteLine("no hay datos registrados");
            }
            else
            {
                Console.Write("ingrese ID del Producto: ");
                int posicion=int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (Id.Contains(posicion))
                {
                  
                    productos.RemoveAt(posicion);
                 
                    Console.WriteLine("producto eliminado con exito");
                }
                else
                {
                    Console.WriteLine("ID no existente");
                }

                Console.WriteLine();
                Console.WriteLine("Presione Enter para continuar");
                Console.ReadLine();
            }
            break;
    }

    Console.Clear();

} while (opcion != "10");