using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test1.Models
{
    public class StudentRepository : IStudedntRepository
    {
        private List<Student> products = new List<Student>();
        private int _nextId = 1;
        public StudentRepository()
        {
            Add(new Student { xuehao = "123456", name = "wang", phone = "123456", xiangmu = "网站", states = "正常", sushehao = "12" });
            Add(new Student { xuehao = "1234567", name = "wang", phone = "123456", xiangmu = "网站", states = "正常", sushehao = "12" });
            Add(new Student { xuehao = "12345677", name = "wang", phone = "123456", xiangmu = "网站", states = "正常", sushehao = "12" });
        
        }

        public Student Add(Student item)
        {
         
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            products.Add(item);
            return item;
        }

        public IEnumerable<Student> GetAll()
        {
          
            return products;
        }
    }
}