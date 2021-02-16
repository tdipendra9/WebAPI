﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class DCandidate
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName =("nvarchar(100)"))]
        public string fullName { get; set; }
        [Column(TypeName = ("nvarchar(10)"))]
        public string  mobile { get; set; }
        [Column(TypeName = ("nvarchar(50)"))]
        public string email  { get; set; }
        public int age { get; set; }
        [Column(TypeName = ("nvarchar(5)"))]
        public string bloodGroup { get; set; }
        [Column(TypeName = ("nvarchar(100)"))]
        public string  address { get; set; }
    }
}
