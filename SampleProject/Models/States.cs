﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SampleProject.Models
{
    public class States
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }


        [StringLength(2)]
        public string ShortName { get; set; }

        public int Tax { get; set; }


    }
}