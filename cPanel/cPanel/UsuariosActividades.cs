//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cPanel
{
    using System;
    using System.Collections.Generic;
    
    public partial class UsuariosActividades
    {
        public int idUsuario { get; set; }
        public int idActividad { get; set; }
        public System.DateTime timestamp { get; set; }
    
        public virtual Actividades Actividades { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}