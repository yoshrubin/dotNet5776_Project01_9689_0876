﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public enum orderHechser { normal, middle, high }; // Check if it has to be in Class?
    public class Order
    {
        //ctor
        public Order(int orderID, DateTime orderTime,int orderBranch, orderHechser orderHechserOrder, int orderStaff, string orderCustomer, string orderCustAddress, string orderCustLocation, int orderCustCC, int orderAge )
        {
            this.orderID = orderID;
            this.orderTime = orderTime;
            this.orderBranch = orderBranch;
            this.orderHechserOrder = orderHechserOrder;
            this.orderStaff = orderStaff;
            this.orderCustAddress = orderCustAddress;
            this.orderCustLocation = orderCustLocation;
            this.orderCustCC = orderCustCC;
            this.orderAge = orderAge;
        }
        //properties
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
        public string orderCustAddress { get; private set; } //Where he is from
        public string orderCustLocation { get; private set; } // Where he wants to be sent to
        public int orderCustCC { get; private set; }
        public int orderAge { get; private set; }
        public List<Ordered_Dish> listofOrderedDishes
        {
            get
            {
                return listofOrderedDishes;
            }
            private set
            {
                listofOrderedDishes = new List<Ordered_Dish>();
            }
        }
        //func
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
        public bool addToOrderDishList(int newItemID, int newItemAmount, Branch branchOfOrder)
        {
            foreach(Dish item in branchOfOrder.listDishforBranch)
            {
                if (item.dishID == newItemID)
                {
                    Ordered_Dish newOrdDish = new Ordered_Dish(orderID, item.dishID, newItemAmount);
                    listofOrderedDishes.Add(newOrdDish);
                    return true;          
                }
            }
            return false;
        }
    }
}
