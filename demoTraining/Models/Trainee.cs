//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demoTraining.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Trainee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trainee()
        {
            this.TraineeEnrollments = new HashSet<TraineeEnrollment>();
        }
    
        public int TraineeID { get; set; }
        public string TraineeName { get; set; }
        public string TraineeEmail { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Education { get; set; }
        public string ProgrammingLanguage { get; set; }
        public Nullable<int> ToeicScore { get; set; }
        public string Address { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TraineeEnrollment> TraineeEnrollments { get; set; }
    }
}
