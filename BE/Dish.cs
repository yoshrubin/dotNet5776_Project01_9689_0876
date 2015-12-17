using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public enum dishSize { small, medium, large }; // Find way to Override w/ string
    public enum dishHechser { normal, middle, high }; // Check if it has to be in Class?
    public class Dish
    {
        public int dishID { get; private set; }
        public string dishName { get; private set; }
        public int dishPrice { get; private set; }
        public dishSize dishSizeDish { get; private set; }
        public dishHechser dishHechserDIsh { get; private set; }
        public override string ToString()
        {
            string temp = null;
            temp += dishID.ToString() + " dish Name:" + dishName + " dish Price:" + dishPrice.ToString();
            return temp;

        }
        public void randDishNum()
        {
            Random r = new Random();
            dishID = r.Next(1, 100);
        }
    }
}
