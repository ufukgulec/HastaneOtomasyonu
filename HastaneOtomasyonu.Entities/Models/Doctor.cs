namespace HastaneOtomasyonu.Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Doctor")]
    public partial class Doctor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doctor()
        {
            Appointment = new HashSet<Appointment>();
        }

        public int id { get; set; }

        public string name { get; set; }

        public string surname { get; set; }

        [StringLength(11)]
        public string identificationnumber { get; set; }

        [StringLength(10)]
        public string phonenumber { get; set; }

        [StringLength(1)]
        public string gender { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateofregistration { get; set; }

        [StringLength(10)]
        public string password { get; set; }

        public int? policlinicid { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment> Appointment { get; set; }

        public virtual Policlinic Policlinic { get; set; }
    }
}
