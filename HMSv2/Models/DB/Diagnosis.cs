//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HMSv2.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Diagnosis
    {
        public int DiagnosisID { get; set; }
        public string Symptoms { get; set; }
        public string DiagnosisProvided { get; set; }
        public int AdministratedBy { get; set; }
        [DataType(DataType.DateTime)]
        public System.DateTime DateOfDiagnosis { get; set; }
        public string FollowUpRequired { get; set; }
        [DataType(DataType.Date)]
        //[DisplayFormat(ApplyFormatInEditMode =true,DataFormatString ="{0:MM/dd/yyyy}")]
        public Nullable<System.DateTime> FollowUpDate { get; set; }
        public int BillID { get; set; }
        public int PatientID { get; set; }
    
        public virtual Billing Billing { get; set; }
        public virtual PatientTable PatientTable { get; set; }
        public virtual Physician Physician { get; set; }
    }
}
