﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DormManagementApi.Models
{
    public class Student
    {
        public long StudentID { set; get; }
        public string Name { set; get; }
        public long PhoneNumber { set; get; }
        public long RoomNumber { set; get; }
        public long AccountNumber { set; get; }
        public string Password { set; get; }
    }
}
