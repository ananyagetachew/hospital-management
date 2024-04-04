﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementSystem.API.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public string EmailAddress { get; set; }

        public Gender Gender { get; set; }
        public int GenderId { get; set; }

        public MaritalStatus MaritalStatus { get; set; }
        public int MaritalStatusId { get; set; }

        public Language Language { get; set; }
        public int LanguageId { get; set; }

        public EducationLevel EducationLevel { get; set; }
        public int EducationLevelId { get; set; }

        public EmployeeRole EmployeeRole { get; set; }
        public String EmployeeRoleId { get; set; }
       // public string RoleId { get; set; }
       public EmployeeAuth EmployeeAuth { get; set; }
       //public string EmployeeAuthId { get; set; }

        public MedicalDepartment MedicalDepartment { get; set; }
        public int MedicalDepartmentId { get; set; }

        public City City { get; set; }
        public int CityId { get; set; }
        public Country Country { get; set; }
        public int CountryId { get; set; }
        public Designation Designation{ get; set; }
        public int DesignationId { get; set; }
        public Specialization Specialization { get; set; }
        public int SpecializationId { get; set; }


        public ICollection<Schedule> Schedules { get; set; }
        public ICollection<Inventory> Inventorys { get; set; }
        public ICollection<Prescription> Prescriptions { get; set; }
        public ICollection<Holiday> Holidays { get; set; }
        public ICollection<Recommendation> Recommendations { get; set; }
        public ICollection<PatientSchedule> PatientSchedules { get; set; }
        public ICollection<BillSchedule> BillSchedules { get; set; }
        public ICollection<MedicineStockHospital> MedicineStockHospitals { get; set; }
        public ICollection<PharmacyMedStock> PharmacyMedStocks { get; set; }
        public ICollection<LabRequest> LabRequests { get; set; }
        public ICollection<Admission> Admissions { get; set; }
        public ICollection<PharmacySale> PharmacySales { get; set; }
        public ICollection<Operation> Operations { get; set; }
        public ICollection<Death> Deaths { get; set; }
        public ICollection<MedicalCertificate> MedicalCertificates { get; set; }
        public ICollection<PreExamCheckup> PreExamCheckups { get; set; }
        public ICollection<AllowanceDeduction> AllowanceDeductions { get; set; }

        public ICollection<EmployeeSalary> EmployeeSalaries { get; set; }
        public ICollection<PayrollReport> PayrollReports { get; set; }
        public ICollection<BillLab> BillLabs{ get; set; }

        public ICollection<Overtime> Overtimes { get; set; }
       
           
      



        public Employee()
        {
            Overtimes = new Collection<Overtime>();
            BillLabs = new Collection<BillLab>();
            PharmacySales = new Collection<PharmacySale>();
            Admissions = new Collection<Admission>();
            LabRequests = new Collection<LabRequest>();
            PharmacyMedStocks = new Collection<PharmacyMedStock>();
            MedicineStockHospitals = new Collection<MedicineStockHospital>();
            Schedules = new Collection<Schedule>();
            Prescriptions = new Collection<Prescription>();
            Holidays = new Collection<Holiday>();
            Recommendations = new Collection<Recommendation>();
            PatientSchedules = new Collection<PatientSchedule>();
            BillSchedules = new Collection<BillSchedule>();
            Inventorys = new Collection<Inventory>();
            Operations = new Collection<Operation>();
            Deaths = new Collection<Death>();
            MedicalCertificates = new Collection<MedicalCertificate>();
            PreExamCheckups = new Collection<PreExamCheckup>();
            AllowanceDeductions = new Collection<AllowanceDeduction>();
            EmployeeSalaries = new Collection<EmployeeSalary>();
            PayrollReports = new Collection<PayrollReport>();
        }
    }
}
