//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order_Snack
    {
        public int Order_Snack1 { get; set; }
        public int OrderId { get; set; }
        public int SnackId { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Snack Snack { get; set; }
    }
}