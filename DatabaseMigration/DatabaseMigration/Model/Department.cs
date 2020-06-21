﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatabaseMigration.Model
{
    public class Department
    {   [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
}