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
        #region // Functions similar to IDAL
        //ADD
        #region // add functions
        public bool addBranch(Branch x)
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
            return available;
        }

        public bool addDish(Dish x)
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
            return available;
        }

        public bool addOrdDish(Ordered_Dish x)
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
            return available;
        }

        public bool addOrder(Order x)
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
            return available;
        }
        #endregion
        //DELETE
        #region // delete functions
        public bool deleteBranch(int x)
        {
            Branch tempB = getBranch(x);
            if (tempB != null)
            {
                branchList.Remove(tempB);
                return true;
            }
            else
                return false;
        }

        public bool deleteDish(int x)
        {
            Dish tempD = getDish(x);
            if (tempD == null)
                return false;
            else
            {
                dishList.Remove(tempD);
                return true;
            }
        }

        public bool deleteOrdDish(int x)
        {
            Ordered_Dish tempOD = getOrdDish(x);
            if (tempOD == null)
                return false;
            else
            {
                ordDishList.Remove(tempOD);
                return true;
            }
        }

        public bool deleteOrder(int x)
        {
            Order tempO = getOrder(x);
            if (tempO == null)
                return false;
            else
            {
                orderList.Remove(tempO);
                return true;
            }
        }
        #endregion
        //UPDATE
        #region // update functions
        public bool updateBranch(Branch x)
        {
            Branch tempB = getBranch(x.branchID);
            if (tempB != null)
            {
                branchList.Remove(tempB);
                branchList.Add(x);
                return true;
            }
            else
                return false;
        }

        public bool updateDish(Dish x)
        {
            Dish tempD = getDish(x.dishID);
            if (tempD != null)
            {
                dishList.Remove(tempD);
                dishList.Add(x);
                return true;
            }
            else
                return false;
        }

        public bool updateOrdDish(Ordered_Dish x)
        {
            Ordered_Dish tempOD = getOrdDish(x.ordDishID);
            if (tempOD != null)
            {
                ordDishList.Remove(tempOD);
                ordDishList.Add(x);
                return true;
            }
            else
                return false;
        }

        public bool updateOrder(Order x)
        {
            Order tempO = getOrder(x.orderID);
            if (tempO != null)
            {
                orderList.Remove(tempO);
                orderList.Add(x);
                return true;
            }
            else
                return false;
        }
        #endregion
        //SUM
        #region // Sum functions
        public List<Branch> sumBranch()
        {
            return branchList;
        }

        public List<Dish> sumDish()
        {
            return dishList;
        }

        public List<Order> sumOrder()
        {
            return orderList;
        }
        #endregion
        //GETS - Search engines to find the class in it's respective list.
        #region // Get functions
        public Dish getDish(int dishID)
        {
            foreach (Dish item in dishList)
                if (item.dishID == dishID)
                    return item;
            return null;
        }

        public Order getOrder(int orderID)
        {
            foreach (Order item in orderList)
                if (item.orderID == orderID)
                    return item;
            return null;
        }

        public Ordered_Dish getOrdDish(int OrdDishID)
        {
            foreach (Ordered_Dish item in ordDishList)
                if (item.ordDishID == OrdDishID)
                    return item;
            return null;
        }

        public Branch getBranch(int branchID)
        {
            foreach (Branch item in branchList)
                if (item.branchID == branchID)
                    return item;
            return null;
        }
        #endregion
        #endregion

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
            var 
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
