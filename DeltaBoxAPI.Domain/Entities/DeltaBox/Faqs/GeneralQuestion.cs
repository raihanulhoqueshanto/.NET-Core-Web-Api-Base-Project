﻿using DeltaboxAPI.Domain.Entities.DeltaBox.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeltaboxAPI.Domain.Entities.DeltaBox.Faqs
{
    [Table("general_question")]
    public class GeneralQuestion : CommonEntity
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Column("question")]
        public string Question { get; set; }

        [Column("answer")]
        public string Answer { get; set; }

        [Column("is_active")]
        public string IsActive { get; set; }
    }
}
