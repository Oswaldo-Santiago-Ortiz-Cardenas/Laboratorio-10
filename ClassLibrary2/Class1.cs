using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.BibliotecaCode
{

    internal class Code
    {
        public static int Menu_principal()
        {
            Console.WriteLine("" +
                "================================\n" +
                "Productos de mPhone:\n" +
                "================================\n" +
                "1: Ventas de mPhone 3000\n" +
                "2: Ventas de mPad 3500\n" +
                "3: Ventas de MAPBrook 3800\n" +
                "4: Ventas de mWatch 8000\n" +
                "5:Salir\n" +
                "================================\n" +
                "Ingrese una opción:\n");
            return opcion1();
        }
        public static int mphone_3000_1()
        {
            Console.WriteLine("" +
                    "================================\n" +
                    "Registrar Venta de mPhone 3000\n" +
                    "================================\n" +
                    "1: Registrar Venta\n" +
                    "2: Registrar Devolución\n" +
                    "3: Menu Principal\n" +
                    "================================\n" +
                    "Ingrese una opción:\n");
            int opcion = opcion1();
            return 0;
        }
        public static int mPad_3500_1()
        {
            Console.WriteLine("" +
                    "================================\n" +
                    "Registrar Venta de mPad 3500\n" +
                    "================================\n" +
                    "1: Registrar Venta\n" +
                    "2: Registrar Devolución\n" +
                    "3: Menu Principal\n" +
                    "================================\n" +
                    "Ingrese una opción:\n");
            return opcion1();
        }
        public static int MAPBrook_3800_1()
        {
            Console.WriteLine("" +
                "================================\n" +
                "Registrar Venta de MAPBrook 3800\n" +
                "================================\n" +
                "1: Registrar Venta\n" +
                "2: Registrar Devolución\n" +
                "3: Menu Principal\n" +
                "================================\n" +
                "Ingrese una opción:\n");
            return opcion1();
        }
        public static int mWatch_8000_1()
        {
            Console.WriteLine("" +
                "================================\n" +
                "Registrar Venta de mWatch 8000\n" +
                "================================\n" +
                "1: Registrar Venta\n" +
                "2: Registrar Devolución\n" +
                "3: Menu Principal\n" +
                "================================\n" +
                "Ingrese una opción:\n");
            return opcion1();
        }
        public static int opcion1()
        {
            string opciontexto = Console.ReadLine();
            Console.Clear();
            return int.Parse(opciontexto);
        }
        public static void letra2()
        {
            Console.WriteLine("" +
                "================================\n" +
                "Registrar devolución de:\n" +
                "================================\n" +
                "Se va a registrar la devolución de\n");
            return;
        }
        public static void letra2_1()
        {
            Console.WriteLine("" +
                "1: Sí\n" +
                "2: No\n" +
                "================================\n" +
                "Ingrese una opción:\n");
            return;
        }
        public static void letras2_2_1()
        {
            Console.Write("" +
                "================================\n" +
                "Registrar venta de:\n" +
                "================================\n" +
                "Se va a registrar la venta de\n");
            return;
        }
    }


}