//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Anotaciones.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Pasword { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public int Idperfilcab { get; set; }
        public bool Estado { get; set; }
        public int Flg_estado { get; set; }
        public int Usu_creacion { get; set; }
        public Nullable<int> Usu_modificacion { get; set; }
        public System.DateTime Fec_Creacion { get; set; }
        public Nullable<System.DateTime> Fec_Modificacion { get; set; }
    }
}
