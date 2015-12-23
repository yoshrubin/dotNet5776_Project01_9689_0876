using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DS;

namespace BL
{
    class BL_imp : DataSource, IBL
    {
        public void addBranch(Branch x)
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

        public void addDish(Dish x)
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

        public void deleteBranch(int x)
        {
            foreach (Branch item in branchList)
                if (x == item.branchID)
                    branchList.Remove(item);
        }

        public void deleteDish(int x)
        {
            foreach (Dish item in dishList)
                if (x == item.dishID)
                    dishList.Remove(item);
        }

        public void deleteOrdDish(int x)
        {
            foreach (Ordered_Dish item in ordDishList)
                if (x == item.ordDishID)
                    ordDishList.Remove(item);
        }

        public void deleteOrder(int x)
        {
            foreach (Order item in orderList)
                if (x == item.orderID)
                    orderList.Remove(item);
        }

        public void updateBranch(Branch x)
        {
            foreach (Branch item in branchList)
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
                    item.ordDishUpdate(x);
                }
        }

        public void updateOrder(Order x)
        {
            foreach (Order item in orderList)
                if (item.orderID == x.orderID)
                {
                    item.orderUpdate(x);
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

        public double SumMoneyDishes(List<Ordered_Dish> x)
        {
            double sumMoney = 0;
            foreach (Ordered_Dish item in x)
            {
                double temp = findDishPrice(item.ordDishID); // sending to func we created to find and return dish price.
                for (int i = 0; i < item.ordDishNum; i++)
                {
                    sumMoney += temp;
                }           
            }
            return sumMoney;
        }

        public bool tooMuchMonies(double x)
        {
            if (x > 2000)
                return true; // true that the order is too expensive
            else
                return false;
        }

        public bool tooLittleHoly(orderHechser x, dishHechser y)
        {
    
        }

        public List<Order> chooseOrder(List<Order> x, Func<Order, bool> predicate)
        {
            
        }

        public double moniesOrder(List<Dish> x)
        {
            
        }

        public double moniesTime(List<Order> x)
        {
            
        }

        public double moniesPlace(List<Branch> x)
        {
            
        }

        public bool tooYoung(Order x)
        {
           
        }

        //EXTRA
        public double findDishPrice(int x)
        {
            foreach (Dish item in dishList)
            {
                if (x == item.dishID)
                    return item.dishPrice;
            }
            return 0;
        }
    }
}
