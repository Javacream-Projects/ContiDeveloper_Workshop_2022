﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Watch.Db.Entities
{
    [Table("WATCHES")]
    public partial class Watch
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("NAME")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Name { get; set; }
        [Column("PRICE")]
        public double? Price { get; set; }
    }
}