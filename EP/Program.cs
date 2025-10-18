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
    class Inventario
    {
        private List<Producto> productos = new List<Producto>();

        public void AgregarProducto()
        {
            Producto p = new Producto();

            Console.Write("Código: ");
            p.Codigo = Console.ReadLine();

            Console.Write("Nombre: ");
            p.Nombre = Console.ReadLine();

            try
            {
                Console.Write("Precio: ");
                p.Precio = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Cantidad: ");
                p.Cantidad = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Entrada inválida. Precio y cantidad deben ser numéricos.");
                return;
            }

            productos.Add(p);
            Console.WriteLine("Producto agregado con éxito.");
        }
        public void ListarProductos()
        {
            Console.WriteLine("\n--- Lista de Productos ---");
            foreach (var p in productos)
                Console.WriteLine(p.ToString());
        }

        public void BuscarPorCodigo()
        {
            Console.Write("Ingrese código a buscar: ");
            string codigo = Console.ReadLine();
            Producto encontrado = productos.Find(p => p.Codigo == codigo);

            if (encontrado != null)
                Console.WriteLine(encontrado.ToString());
            else
                Console.WriteLine("Producto no encontrado.");
        }