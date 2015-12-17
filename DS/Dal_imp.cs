using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace DS
{
    class Dal_imp : DataSource, IDAL
    {
        void IDAL.addBranch(Branch x)
        {
            bool available = true;
            if (x.branchID > 0)
            {
                foreach (Branch item in branchList)
                {
                    if (item.branchID == x.branchID) // search through if key exists in list.
                        available = false;
                }
            }
            if (x.branchID == 0)
            {
                do
                {
                    available = true;
                    x.randBranchNum(); // func in Branch.cs that gives a new random branchNum -> [1,1000]
                    foreach (Branch item in branchList)
                    {
                        if (item.branchID == x.branchID)
                            available = false;
                    }
                } while (!available); // The fact that the number exists in the list doesn't mean we arent going to add it, just give it a new random numer
            }
            if (available) // add to the list.
                branchList.Add(x);
        }

        void IDAL.addDish(Dish x)
        {
            bool available = true;
            if (x.dishID > 0)
            {
                foreach (Dish item in dishList)
                {
                    if (item.dishID == x.dishID) // search through if key exists in list.
                        available = false;
                }
            }
            if (x.dishID == 0)
            {
                do
                {
                    available = true;
                    x.randDishNum(); // func in Branch.cs that gives a new random dishNum -> [1,100]
                    foreach (Dish item in dishList)
                    {
                        if (item.dishID == x.dishID)
                            available = false;
                    }
                } while (!available); // The fact that the number exists in the list doesn't mean we arent going to add it, just give it a new random numer
            }
            if (available) // add to the list.
                dishList.Add(x);
        }

        public void addOrdDish(Ordered_Dish x)
        {
            bool available = true;
            if (x.ordDishID > 0)
            {
                foreach (Ordered_Dish item in ordDishList)
                {
                    if (item.ordDishID == x.ordDishID) // search through if key exists in list.
                        available = false;
                }
            }
            if (x.ordDishID == 0)
            {
                do
                {
                    available = true;
                    x.randOrdDishNum(); // func in Branch.cs that gives a new random ordDishNum -> [1,1000]
                    foreach (Ordered_Dish item in ordDishList)
                    {
                        if (item.ordDishID == x.ordDishID)
                            available = false;
                    }
                } while (!available); // The fact that the number exists in the list doesn't mean we arent going to add it, just give it a new random numer
            }
            if (available) // add to the list.
                ordDishList.Add(x);
        }

        public void addOrder(Order x)
        {
            bool available = true;
            if (x.orderID > 0)
            {
                foreach (Order item in orderList)
                {
                    if (item.orderID == x.orderID) // search through if key exists in list.
                        available = false;
                }
            }
            if (x.orderID == 0)
            {
                do
                {
                    available = true;
                    x.randOrderNum(); // func in Branch.cs that gives a new random orderNum -> [1,10000]
                    foreach (Order item in orderList)
                    {
                        if (item.orderID == x.orderID)
                            available = false;
                    }
                } while (!available); // The fact that the number exists in the list doesn't mean we arent going to add it, just give it a new random numer
            }
            if (available) // add to the list.
                orderList.Add(x);
        }

        public void deleteBranch(Branch x)
        {
            foreach (Branch item in branchList)
                if (x.branchID == item.branchID)
                    branchList.Remove(item);
        }

        public void deleteDish(Dish x)
        {
            foreach (Dish item in dishList)
                if (x.dishID == item.dishID)
                    dishList.Remove(item);
        }

        public void deleteOrdDish(Ordered_Dish x)
        {
            foreach (Ordered_Dish item in ordDishList)
                if (x.ordDishID == item.ordDishID)
                    ordDishList.Remove(item);
        }

        public void deleteOrder(Order x)
        {
            foreach (Order item in orderList)
                if (x.orderID == item.orderID)
                    orderList.Remove(item);
        }

        public void updateBranch(Branch x)
        {
           foreach(Branch item in branchList)
                if (item.branchID == x.branchID)
                {
                    item.updateBranch(x);
                }
        }

        public void updateDish(Dish x)
        {
            foreach (Dish item in dishList)
                if (item.dishID == x.dishID)
                {
                    item.updateDish(x);
                }
        }

        public void updateOrdDish(Ordered_Dish x)
        {
            foreach (Ordered_Dish item in ordDishList)
                if (item.ordDishID == x.ordDishID)
                {
                    item.updateOrdDish(x);
                }
        }

        public void updateOrder(Order x)
        {
            foreach (Order item in orderList)
                if (item.orderID == x.orderID)
                {
                    item.updateOrder(x);
                }
        }

        /* PURPOSE OF BELOW FUNCTIONS UNKNOWN */

        public void sumBranch(List<Branch> x)
        {

        }

        public void sumDish(List<Dish> x)
        {

        }

        public void sumOrder(List<Order> x)
        {

        }
    }
}
