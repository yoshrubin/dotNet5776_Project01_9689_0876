using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Ordered_Dish
    {
        public int ordDishID { get; private set; }
        public int ordDishNum { get; private set; }
        public int ordDishTypeNum { get; private set; }
        public override string ToString()
        {
            string temp = null;
            temp += ordDishID.ToString() + " ordered dish num: " + ordDishNum.ToString() + " ordered dish amount: " + ordDishTypeNum.ToString();
            return temp;
        }
        public void randOrdDishNum()
        {
            Random r = new Random();
            ordDishID = r.Next(1, 1000);
        }
        public void ordDishUpdate (Ordered_Dish x)
        {
            ordDishNum = x.ordDishNum;
            ordDishTypeNum = x.ordDishTypeNum;
        }
    }
}
