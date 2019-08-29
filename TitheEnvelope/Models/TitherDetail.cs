﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TitheEnvelopeApi.Models
{
    [Table("TitherDetail", Schema ="dbo")]
    public class TitherDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "TitherDetailId")]
        public long Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "NameOfTither")]
        public string NameOfTither { get; set; }
    }
}
