namespace HastaneOtomasyonu.Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hospital")]
    public partial class Hospital
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hospital()
        {
            Policlinic = new HashSet<Policlinic>();
        }

        public int id { get; set; }

        public string name { get; set; }

        [StringLength(10)]
        public string phonenumber { get; set; }

        public int? cityid { get; set; }

        public virtual City City { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Policlinic> Policlinic { get; set; }
        public virtual ICollection<Doctor> Doctor { get; set; }
    }
}
