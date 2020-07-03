using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DormManagementApi.Models
{
    public class OrderOperation
    {

		List<Order> orderList;
		public List<Order> OrderList { get => orderList; set => orderList = value; }
	}
}
