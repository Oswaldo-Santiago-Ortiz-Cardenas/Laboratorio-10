using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalVentasMPhones = 0;
            int totaldevueltasmphones = 0;
            int totalVentasMPads = 0;
            int totaldevueltasmpads = 0;
            int totalVentasMAPBrooks = 0;
            int totaldevueltasmapbrooks = 0;
            int totalVentasMWatches = 0;
            int totaldevueltasmwatches = 0;
            int opcion;
            int opcion_1;
            int opcion2;
            int opcion2_1;

            do
            {
                opcion = MenuPrincipal();
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        MPhone_3000_1();
                        opcion_1 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (opcion_1)
                        {
                            case 1:
                                Console.WriteLine("Un mPhone 3000 ¿Desea Continuar?");
                                Console.WriteLine("1: Sí");
                                Console.WriteLine("2: No");
                                opcion2 = int.Parse(Console.ReadLine());

                                if (opcion2 == 1)
                                {
                                    totalVentasMPhones++;
                                }

                                Console.Clear();
                                break;

                            case 2:
                                Console.WriteLine("Un mPhone 3000 ¿Desea Continuar?");
                                Console.WriteLine("1: Sí");
                                Console.WriteLine("2: No");
                                opcion2_1 = int.Parse(Console.ReadLine());
                                Console.Clear();

                                if (opcion2_1 == 1)
                                {
                                    totaldevueltasmphones++;
                                }
                                break;
                        }
                        break;

                    case 2:
                        MPad_3500_1();
                        opcion_1 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (opcion_1)
                        {
                            case 1:
                                Console.WriteLine("Un mPad 3500 ¿Desea Continuar?");
                                Console.WriteLine("1: Sí");
                                Console.WriteLine("2: No");
                                opcion2_1 = int.Parse(Console.ReadLine());
                                Console.Clear();

                                if (opcion2_1 == 1)
                                {
                                    totalVentasMPads++;
                                }
                                break;

                            case 2:
                                Console.WriteLine("Un mPad 3500 ¿Desea Continuar?");
                                Console.WriteLine("1: Sí");
                                Console.WriteLine("2: No");
                                opcion2_1 = int.Parse(Console.ReadLine());
                                Console.Clear();

                                if (opcion2_1 == 1)
                                {
                                    totaldevueltasmpads++;
                                }
                                break;
                        }
                        break;

                    case 3:
                        MAPBrook_3800_1();
                        opcion_1 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (opcion_1)
                        {
                            case 1:
                                Console.WriteLine("Un MAPBrook 3800 ¿Desea Continuar?");
                                Console.WriteLine("1: Sí");
                                Console.WriteLine("2: No");
                                opcion2 = int.Parse(Console.ReadLine());

                                if (opcion2 == 1)
                                {
                                    totalVentasMAPBrooks++;
                                }

                                Console.Clear();
                                break;

                            case 2:
                                Console.WriteLine("Un MAPBrook 3800 ¿Desea Continuar?");
                                Console.WriteLine("1: Sí");
                                Console.WriteLine("2: No");
                                opcion2_1 = int.Parse(Console.ReadLine());
                                Console.Clear();

                                if (opcion2_1 == 1)
                                {
                                    totaldevueltasmapbrooks++;
                                }
                                break;
                        }
                        break;

                    case 4:
                        MWatch_8000_1();
                        opcion_1 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (opcion_1)
                        {
                            case 1:
                                Console.WriteLine("Un mWatch 8000 ¿Desea Continuar?");
                                Console.WriteLine("1: Sí");
                                Console.WriteLine("2: No");
                                opcion2 = int.Parse(Console.ReadLine());

                                if (opcion2 == 1)
                                {
                                    totalVentasMWatches++;
                                }

                                Console.Clear();
                                break;

                            case 2:
                                Console.WriteLine("Un mWatch 8000 ¿Desea Continuar?");
                                Console.WriteLine("1: Sí");
                                Console.WriteLine("2: No");
                                opcion2_1 = int.Parse(Console.ReadLine());
                                Console.Clear();

                                if (opcion2_1 == 1)
                                {
                                    totaldevueltasmwatches++;
                                }
                                break;

                        }
                        break;

                    case 5:
                        Console.WriteLine("==========ReporteFinal==========\n");
                        Console.WriteLine("Productos Vendidos | Cantidad");
                        Console.WriteLine("mPhones            | " + totalVentasMPhones);
                        Console.WriteLine("mPads              | " + totalVentasMPads);
                        Console.WriteLine("MAPBrooks          | " + totalVentasMAPBrooks);
                        Console.WriteLine("mWatches           | " + totalVentasMWatches);
                        int totalVentasProductos = totalVentasMPhones + totalVentasMPads + totalVentasMAPBrooks + totalVentasMWatches;
                        Console.WriteLine("================================\n");
                        Console.WriteLine("Total              | " + totalVentasProductos);
                        Console.WriteLine("================================\n" +
                            "¡Hasta Luego!\n");
                        Console.ReadKey();
                        break;
                }
            }
            while (opcion != 5);
        }

        static int MenuPrincipal()
        {
            Console.WriteLine("Menú Principal:");
            Console.WriteLine("1. Comprar mPhone 3000");
            Console.WriteLine("2. Comprar mPad 3500");
            Console.WriteLine("3. Comprar MAPBrook 3800");
            Console.WriteLine("4. Comprar mWatch 8000");
            Console.WriteLine("5. Salir");
            Console.Write("Elija una opción: ");
            return int.Parse(Console.ReadLine());
        }

        static void MPhone_3000_1()
        {
            Console.WriteLine("Menú mPhone 3000:");
            Console.WriteLine("1. Comprar mPhone 3000");
            Console.WriteLine("2. Devolver mPhone 3000");
            Console.Write("Elija una opción: ");
        }

        static void MPad_3500_1()
        {
            Console.WriteLine("Menú mPad 3500:");
            Console.WriteLine("1. Comprar mPad 3500");
            Console.WriteLine("2. Devolver mPad 3500");
            Console.Write("Elija una opción: ");
        }

        static void MAPBrook_3800_1()
        {
            Console.WriteLine("Menú MAPBrook 3800:");
            Console.WriteLine("1. Comprar MAPBrook 3800");
            Console.WriteLine("2. Devolver MAPBrook 3800");
            Console.Write("Elija una opción: ");
        }

        static void MWatch_8000_1()
        {
            Console.WriteLine("Menú mWatch 8000:");
            Console.WriteLine("1. Comprar mWatch 8000");
            Console.WriteLine("2. Devolver mWatch 8000");
            Console.Write("Elija una opción: ");
        }
    }
}