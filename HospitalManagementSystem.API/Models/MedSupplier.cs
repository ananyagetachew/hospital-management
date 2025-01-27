﻿using HospitalManagementSystem.API.Models.Base;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HospitalManagementSystem.API.Models
{
    public class MedSupplier : BaseModel
    {
        public string Address { get; set; }

        public int PhoneNumber { get; set; }

        public ICollection<MedicineStockHospital> MedicineStockHospitals { get; set; }
        public ICollection<PharmacyMedStock> PharmacyMedStocks { get; set; }


        public MedSupplier()
        {
            PharmacyMedStocks = new Collection<PharmacyMedStock>();

            MedicineStockHospitals = new Collection<MedicineStockHospital>();
        }
    }
}
