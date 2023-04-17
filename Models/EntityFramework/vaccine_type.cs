namespace Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vaccine_type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public vaccine_type()
        {
            vaccine_lot = new HashSet<vaccine_lot>();
            bill_vaccine = new HashSet<bill_vaccine>();
            pet_vaccine = new HashSet<pet_vaccine>();
        }

        [Key]
        [StringLength(10)]
        public string vaccine_code { get; set; }

        [StringLength(50)]
        public string vaccine_name { get; set; }

        [StringLength(50)]
        public string publisher_name { get; set; }

        public int? price_each { get; set; }

        [StringLength(400)]
        public string note { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vaccine_lot> vaccine_lot { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bill_vaccine> bill_vaccine { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pet_vaccine> pet_vaccine { get; set; }
    }
}