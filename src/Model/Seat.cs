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
    
    public partial class Seat
    {
        public int SeatId { get; set; }
        public string Letter { get; set; }
        public string Number { get; set; }
        public string Status { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Flag { get; set; }
        public int ShowTimeId { get; set; }
    
        public virtual ShowTime ShowTime { get; set; }
    }
}
