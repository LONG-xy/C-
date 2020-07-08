using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.Models
{
    interface IStudedntRepository
    {
        IEnumerable<Student> GetAll();

        Student Add(Student item);
    }
}
