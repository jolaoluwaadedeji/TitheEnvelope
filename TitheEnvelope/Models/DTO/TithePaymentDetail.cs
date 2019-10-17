﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TitheEnvelopeApi.Models.DTO.Interface;

namespace TitheEnvelopeApi.Models.DTO
{
    [Table("TithePaymentDetail", Schema ="dbo")]
    public class TithePaymentDetail:BaseObject, IEntity
    {
               
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

        //[Column(TypeName = "bigint")]
        //[Display(Name = "TitherDetailId")]
        //public long ? TitherDetailId { get; set; }

        public TitherDetail TitherDetail { get; set; }

    }
}
