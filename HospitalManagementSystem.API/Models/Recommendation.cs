﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementSystem.API.Models
{
    public class Recommendation
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
        public Patient Patient { get; set; }
        public int PatientId { get; set; }
    }
}
