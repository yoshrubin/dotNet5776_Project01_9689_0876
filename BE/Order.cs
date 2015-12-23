using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public enum orderHechser { normal, middle, high }; // Check if it has to be in Class?
    public class Order
    {
        public int orderID
        {
            get
            {
                return orderID;
            }
            private set
            {
                if (value > 99999999  && value <= 9999999)
                    return;
                else
                    orderID = value;
            }
        }
        public DateTime orderTime { get; private set; }
        public int orderBranch { get; private set; }
        public orderHechser orderHechserOrder { get; private set; }
        public int orderStaff { get; private set; }
        public string orderCustomer { get; private set; }
        public string orderCustAddress { get; private set; }
        public string orderCustLocation { get; private set; }
        public int orderCustCC { get; private set; }
        public override string ToString()
        {
            string temp = null;
            temp += orderID.ToString() + " order time: " + orderTime.ToString() + " order branch: " + orderBranch.ToString() + " order customer: " + orderCustomer + " order customer's current location: " + orderCustLocation;
            return temp;
        }
        public void randOrderNum()
        {
            Random r = new Random();
            orderID = r.Next(1, 10000);
        }
    }
}
