using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Producto
    {

        [JsonObject(MemberSerialization.OptIn)]


        public int ID {get;set;}
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public int Existencia { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaVencimiento{ get; set; }

        public UnidadMedida UnidadMedida { get; set; }

        public class ProductoPrecioComparer : IComparer<Producto>
        {
            public int Compare(Producto x, Producto y)
            {
                if(x.Precio < y.Precio)
                {
                    return 1;
                }else if(x.Precio > y.Precio)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

    }
}
