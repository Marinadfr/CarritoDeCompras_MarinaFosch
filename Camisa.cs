using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras
{
    class Camisa
    {
        public static int cantidadCamisas;
        public float precio;
        public static float precioTotal;
        public double descuentoAplicado;
        public static double precioFinal;

        public Camisa(float precio, float descuentoAplicado)
        {
            this.precio = precio;
            this.descuentoAplicado = descuentoAplicado;
        }

        public void calcularDescuento()
        {
            if (cantidadCamisas > 3 && cantidadCamisas < 5)
            {
                descuentoAplicado = 0.10;
            } 
            else if(cantidadCamisas >= 5)
            {
                descuentoAplicado = 0.20;
            }

            precioFinal = precioTotal - precioTotal * descuentoAplicado;
        } 
       
    }
}
