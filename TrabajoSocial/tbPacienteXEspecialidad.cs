//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrabajoSocial
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbPacienteXEspecialidad
    {
        public int Pte_Id { get; set; }
        public int Esp_Id { get; set; }
        public string PteXEsp_UsuarioCrea { get; set; }
        public Nullable<System.DateTime> PteXEsp_FechaCrea { get; set; }
        public string PteXEsp_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> PteXEsp_FechaModifica { get; set; }
    
        public virtual tbEspecialidades tbEspecialidades { get; set; }
        public virtual tbPacientes tbPacientes { get; set; }
    }
}
