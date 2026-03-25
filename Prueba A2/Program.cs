using System.Collections;

class cortoa2
{
    public static void Main(string[] args)
    {
        ArrayList productos1 = new ArrayList { "Frutas", "carnes", "verduras", "bebidas", "postres" };
        ArrayList productos2 = new ArrayList { "muebles", "decoración", "jardín", "habitación" };

        int[] precioproduct1 = { 20, 35, 10, 15, 25 };
        int[] precioproduct2 = { 40, 25, 18, 20 };

        ArrayList categoríacomida = new ArrayList { productos1 };
        ArrayList categoriahogar = new ArrayList { productos2 };


        Console.WriteLine("Bienvenido, seleccione la opción que desea emplear");
        Console.WriteLine("----MENÚ----");
        Console.WriteLine("1. Agregar productos");
        Console.WriteLine("2. Mostar todos los productos");
        Console.WriteLine("3. Calcular promedio de precios");
        Console.WriteLine("4. Mostrar producto con mayor precio");
        Console.WriteLine("5. Mostrar producto con menor precio");
        Console.WriteLine("6. productos próximos a vencer");
        Console.WriteLine("7. buscar producto (nombre, ID, categoría)");
        Console.WriteLine("8. Salir");
        int op = int.Parse(Console.ReadLine());
        switch (op)
        {
            case 1:



                Console.WriteLine("Ingrese el producto que desea agregar");
                string newproduct = Console.ReadLine();
                productos1.Add(newproduct);
                Console.WriteLine("----MENÚ----");
                foreach (string p in productos1)
                    Console.WriteLine("*" + p);
                break;

            case 2:
                Console.WriteLine("------LISTA DE PRODUCTOS DE ALIMENTOS------");
                foreach (string p in productos1)
                    Console.WriteLine("*" + p);

                Console.WriteLine("------LISTA DE PRODUCTOS PARA EL HOGAR------");

                foreach (string p in productos2)
                    Console.WriteLine("*" + p);
                break;

            case 3:
                int promedioprecios1 = calcularpromedio1(precioproduct1);
                int promedioprecios2 = calcularpromedio2(precioproduct2);

                Console.WriteLine("------PROMEDIO DE PRECIOS DE ALIMENTOS------");
                Console.WriteLine($"El valor del promedio de  los{precioproduct1.Length} productos es de: {promedioprecios1}");

                Console.WriteLine("------PROMEDIO DE PRECIOS DE PRODUCTOS PARA HOGAR------");
                Console.WriteLine($"El valor del promedio de  los{precioproduct2.Length} productos es de: {promedioprecios2}");



                break;








        }









    }
    static int calcularpromedio1(int[] valorproduct1)
    {
        int suma = 0;
        foreach (int n in valorproduct1)
        {
            suma += n;

        }
        return suma / valorproduct1.Length;
    }

    static int calcularpromedio2(int[] valorproduct2)
    {

        int suma = 0;
        foreach (int n in valorproduct2)
        {
            suma += n;

        }
        return suma / valorproduct2.Length;
    }

}

//prueba de proramacion 1




