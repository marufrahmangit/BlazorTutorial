﻿using EmployeeManagement.Models.CustomValidators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required(ErrorMessage ="The First Name field is required")]
        [MinLength(2)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "The Last Name field is required")]
        public string LastName { get; set; }
        [EmailAddress]
        [EmailDomainValidator(AllowedDomain ="mail.com", 
            ErrorMessage ="Only mail.com is allowed")]
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public int DepartmentId { get; set; }
        public string PhotoPath { get; set; }
        public Department Department { get; set; }
    }
}
