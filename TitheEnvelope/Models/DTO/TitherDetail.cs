using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TitheEnvelopeApi.Models.DTO
{
    [Table("TitherDetail", Schema ="dbo")]
    public class TitherDetail: BaseObject
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Display(Name = "TitherDetailId")]
        //public long TitherDetailId { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "NameOfTither")]
        public string NameOfTither { get; set; }

        public ICollection<TithePaymentDetail> TithePaymentDetails { get; set; }
    }
}
