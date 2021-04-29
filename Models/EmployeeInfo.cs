using System;
using System.Collections.Generic;

#nullable disable

namespace simpleapi.Models
{
    public partial class EmployeeInfo
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }
}
