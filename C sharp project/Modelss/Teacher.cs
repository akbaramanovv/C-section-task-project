//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace C_sharp_project.Modelss
{
    using System;
    using System.Collections.Generic;
    
    public partial class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int SpecialityID { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<double> Salary { get; set; }
    
        public virtual Education Education { get; set; }
    }
}
