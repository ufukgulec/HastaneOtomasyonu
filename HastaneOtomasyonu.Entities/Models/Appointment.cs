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
        public int id { get; set; }

        public int patientid { get; set; }

        public int doctorid { get; set; }
        public int policlinicid { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        public TimeSpan? hour { get; set; }

        [Column(TypeName = "date")]
        public DateTime? currentdate { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual Patient Patient { get; set; }
        public virtual Policlinic Policlinic { get; set; }
    }
}
