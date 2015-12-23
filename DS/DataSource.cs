using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DS
{
    public class DataSource
    {
        public static List<Branch> branchList;
        public static List<Order> orderList;
        public static List<Dish> dishList;
        public static List<Ordered_Dish> ordDishList;
        public DataSource()
        {
            branchList = new List<Branch>();
            orderList = new List<Order>();
            dishList = new List<Dish>();
            ordDishList = new List<Ordered_Dish>();
        }
    }
}
