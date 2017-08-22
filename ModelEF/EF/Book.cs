namespace ModelEF.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        public long ID { get; set; }

        public long? CateID { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        [Column(TypeName = "ntext")]
        public string Detail { get; set; }

        public double? Price { get; set; }

        [StringLength(500)]
        public string ImagePath { get; set; }

        [StringLength(500)]
        public string Meta_Keyword { get; set; }

        [StringLength(500)]
        public string Meta_Description { get; set; }

        public bool? Status { get; set; }

        public bool? ShowOnHome { get; set; }

        public virtual Category Category { get; set; }
    }
}
