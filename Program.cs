using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            bool salir = false;
            Camisa camisa = new Camisa(1000, 0);
            do
            {
                Menu.menuPrincipal(camisa);

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Usted agregó una camisa.");
                        Camisa.cantidadCamisas++;
                        Camisa.precioTotal = Camisa.precioTotal + camisa.precio;
                        camisa.calcularDescuento();
                        break;
                    case 2:
                        Console.WriteLine("Usted eliminó una camisa del carro de compras.");
                        Camisa.cantidadCamisas--;
                        break;
                    case 3:
                        Console.WriteLine("Usted eligió salir.");
                        salir = Menu.confirmarSalida();
                        break;
                }

            } while (opcion < 3 || salir == false);

            
        }
    }
}
