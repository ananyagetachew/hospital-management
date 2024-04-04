﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementSystem.API.Dtos.Specializations
{
    public class SpecializationFormDto
    {
        [Required]
        [StringLength(15)]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
