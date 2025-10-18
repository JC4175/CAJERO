using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAJERO
{
    public class PRODUCTO
    {
        //ATRIBUTOS PARA PRODUCTOS
        public string NOMBRE;
        public double PRECIO;

        //CONSTRUCTOR PARA PRODUCTOS
        public PRODUCTO(string NOMBRE, double PRECIO)
        {
            this.NOMBRE = NOMBRE;
            this.PRECIO = PRECIO;
        }

        //METODO PARA MOSTRAR INFORMACION DE PRODUCTOS
        public string MostrarProducto()
        {
            return "NOMBRE: " + NOMBRE + " PRECIO: " + PRECIO;
        }

    }
}
