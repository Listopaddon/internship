﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.EntityModels
{
    public enum Gender
    {
        [Description("Мужской")]
        Male,
        [Description("Женский")]
        Female
    };
    public class PatientCard
    {
        private int age; //fix bag number 4. read file FixBags.docx
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String Address { get; set; }
        public String PhoneNumber { get; set; }
        public List<Request> Requests { get; set; }
        public Int32 Age  //fix bag number 1. read file FixBags.docx
        {
            get
            {
                DateTime today = DateTime.Now;
                age = today.Year - DateOfBirth.Year;
                if (DateOfBirth.AddYears(age) > today) { age--; }
                return age;
            }
        }
    }
}
