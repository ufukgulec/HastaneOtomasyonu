namespace HastaneOtomasyonu.Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Appointment")]
    public partial class Appointment
    {
        public int ID { get; set; }

        public int PatientId { get; set; }

        public int DoctorId { get; set; }

        public int PoliclinicId { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public TimeSpan Hour { get; set; }

        [Column(TypeName = "date")]
        public DateTime CurrentDate { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual Policlinic Policlinic { get; set; }
    }
}
