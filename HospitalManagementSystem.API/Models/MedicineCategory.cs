﻿using HospitalManagementSystem.API.Models.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementSystem.API.Models
{
    public class MedicineCategory:BaseModel
    {
        public ICollection<Medication> Medications { get; set; }

        public MedicineCategory()
        {
            Medications = new Collection<Medication>();
        }
    }
}
