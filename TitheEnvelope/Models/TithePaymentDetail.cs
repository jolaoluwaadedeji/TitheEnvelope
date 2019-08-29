using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TitheEnvelopeApi.Models
{
    [Table("TithePaymentDetail", Schema ="dbo")]
    public class TithePaymentDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name ="TithePaymentId")]
        public long Id { get; set; }
        
        [Required]
        [Column(TypeName = "datetime")]
        [Display(Name = "DateOfPayment")]
        public DateTime DateOfPayment { get; set; }

        [Required]
        [Column(TypeName = "money")]
        [Display(Name = "Amount")]
        public decimal Amount { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "PaymentMethod")]
        public string PaymentMethod { get; set; }

        [Required]
        [Column(TypeName = "bigint")]
        [Display(Name = "TitherNo")]
        public long TitherNo { get; set; }

    }
}
