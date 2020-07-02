using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace DormManagementApp
{
    public class EntityBase
    {
        [Key] //主键 
        public string No { get; set; }
    }
}
