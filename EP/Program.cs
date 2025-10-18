using System;
using System.Collections.Generic;

namespace ElectroPlus
{
    class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        public override string ToString()
        {
            return $"{Codigo} | {Nombre} | {Precio} | {Cantidad}";
        }
    }