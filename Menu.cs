using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras
{
    class Menu
    {
        public static void menuPrincipal(Camisa camisa)
        {
           
                Console.WriteLine("SHOPPING ONLINE DE CAMISAS - Ventas minoristas y mayoristas.");
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("MENÚ PRINCIPAL: ");
                Console.WriteLine("1- Añadir camisa al carro de compras.");
                Console.WriteLine("2- Eliminar camisa del carro de compras.");
                Console.WriteLine("3- Salir.");
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("Cantidad de camisas en el carro de compras: "+Camisa.cantidadCamisas);
                Console.WriteLine("Precio unitario: $1000 "+camisa.precio);
                Console.WriteLine("Precio total sin descuento: "+Camisa.precioTotal);
                Console.WriteLine("Tipo de descuento aplicado: "+camisa.descuentoAplicado);
                Console.WriteLine("Precio final con descuento: "+Camisa.precioFinal);
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("Ingrese una opción del menú: ");
        }

        public static bool confirmarSalida()
        {
            Console.WriteLine("Desea confirmar salir? SI (S) NO (N)");
            string opcionConfirmar = Console.ReadLine();

            if (opcionConfirmar == "S")
            {
                return true;
            }
            else if (opcionConfirmar == "N")
            {
                return false;
            }
            return false;
        } 
    }
}
