//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChamadosImpressora.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblLocacao
    {
        public int ID_Locacao { get; set; }
        public int ID_Seccional { get; set; }
        public int ID_Departamento { get; set; }
        public int ID_Impressora { get; set; }
        public Nullable<System.DateTime> DataDeCadastro { get; set; }
        public Nullable<System.DateTime> DataUltimaAlteracao { get; set; }
    
        public virtual tblDepartamento tblDepartamento { get; set; }
        public virtual tblImpressora tblImpressora { get; set; }
        public virtual tblSeccional tblSeccional { get; set; }
    }
}
