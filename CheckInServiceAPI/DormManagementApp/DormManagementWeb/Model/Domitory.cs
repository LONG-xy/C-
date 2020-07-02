using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DormManagementWeb
{
    public class Domitory
    {
        [Key]
        public long DomitoryID { get; set; }
        public string PhoneNumber { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public int Count { get; set; }
    }
}
