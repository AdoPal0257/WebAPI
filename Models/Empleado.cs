//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiPruebaCrud.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empleado
    {
        public int id_empleado { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string cargo { get; set; }
        public string correo { get; set; }
        public string celular { get; set; }
        public Nullable<decimal> salario { get; set; }
    }
}