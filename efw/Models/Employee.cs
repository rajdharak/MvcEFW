﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace efw.Models
{
    public class Employee
    {

        [Table("")]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
}