using System;
using System.Collections.Generic;

#nullable disable

namespace CORE_CRUD.Db_Connect
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }
    }
}
