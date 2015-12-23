using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Ordered_Dish
    {
        //ctor
        public Ordered_Dish(int ordDishID, int ordDishNum, int ordDishAmount)
        {
            this.ordDishID = ordDishID;
            this.ordDishNum = ordDishNum;
            this.ordDishAmount = ordDishAmount;
        }
        //properties
        public int ordDishID { get; private set; } // Same ID as the Order
        public int ordDishNum { get; private set; } // Same ID as the Dish
        public int ordDishAmount { get; private set; } // The amount of said Dish
        //funcs
        public override string ToString()
        {
            string temp = null;
            temp += ordDishID.ToString() + " ordered dish num: " + ordDishNum.ToString() + " ordered dish amount: " + ordDishAmount.ToString();
            return temp;
        }
        public void randOrdDishNum()
        {
            Random r = new Random();
            ordDishID = r.Next(1, 1000);
        }
    }
}
