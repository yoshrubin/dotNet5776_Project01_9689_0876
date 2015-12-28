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
        //Same as Dal_imp
        #region
        //ADD
        public bool addBranch(Branch x, List<Branch> branchList)
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

        public bool addDish(Dish x, List<Dish> dishList)
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

        public bool addOrdDish(Ordered_Dish x, List<Ordered_Dish> ordDishList)
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

        public bool addOrder(Order x, List<Order> orderList)
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
        //DELETE
        public bool deleteBranch(int x, List<Branch> branchList)
        {
            Branch tempB = getBranch(x, branchList);
            if (tempB != null)
            {
                branchList.Remove(tempB);
                return true;
            }
            else
                return false;
        }

        public bool deleteDish(int x, List<Dish> dishList)
        {
            Dish tempD = getDish(x, dishList);
            if (tempD == null)
                return false;
            else
            {
                dishList.Remove(tempD);
                return true;
            }
        }

        public bool deleteOrdDish(int x, List<Ordered_Dish> ordDishList)
        {
            Ordered_Dish tempOD = getOrdDish(x, ordDishList);
            if (tempOD == null)
                return false;
            else
            {
                ordDishList.Remove(tempOD);
                return true;
            }
        }

        public bool deleteOrder(int x, List<Order> orderList)
        {
            Order tempO = getOrder(x, orderList);
            if (tempO == null)
                return false;
            else
            {
                orderList.Remove(tempO);
                return true;
            }
        }
        //UPDATE
        public bool updateBranch(Branch x, List<Branch> branchList)
        {
            Branch tempB = getBranch(x.branchID, branchList);
            if (tempB != null)
            {
                branchList.Remove(tempB);
                branchList.Add(x);
                return true;
            }
            else
                return false;
        }

        public bool updateDish(Dish x, List<Dish> dishList)
        {
            Dish tempD = getDish(x.dishID, dishList);
            if (tempD != null)
            {
                dishList.Remove(tempD);
                dishList.Add(x);
                return true;
            }
            else
                return false;
        }

        public bool updateOrdDish(Ordered_Dish x, List<Ordered_Dish> ordDishList)
        {
            Ordered_Dish tempOD = getOrdDish(x.ordDishID, ordDishList);
            if (tempOD != null)
            {
                ordDishList.Remove(tempOD);
                ordDishList.Add(x);
                return true;
            }
            else
                return false;
        }

        public bool updateOrder(Order x, List<Order> orderList)
        {
            Order tempO = getOrder(x.orderID, orderList);
            if (tempO != null)
            {
                orderList.Remove(tempO);
                orderList.Add(x);
                return true;
            }
            else
                return false;
        }
        //SUM
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
        //GETS
        public Dish getDish(int dishID, List<Dish> dishList)
        {
            foreach (Dish item in dishList)
                if (item.dishID == dishID)
                    return item;
            return null;
        }

        public Order getOrder(int orderID, List<Order> orderList)
        {
            foreach (Order item in orderList)
                if (item.orderID == orderID)
                    return item;
            return null;
        }

        public Ordered_Dish getOrdDish(int OrdDishID, List<Ordered_Dish> ordDishList)
        {
            foreach (Ordered_Dish item in ordDishList)
                if (item.ordDishID == OrdDishID)
                    return item;
            return null;
        }

        public Branch getBranch(int branchID, List<Branch> branchList)
        {
            foreach (Branch item in branchList)
                if (item.branchID == branchID)
                    return item;
            return null;
        }
#endregion

        public double SumMoneyDishes(Branch x)
        {
            double sumMoney = 0;
            foreach (Order mainItem in x.listOrderforBranch)
            {
                foreach (Ordered_Dish item in mainItem.listofOrderedDishes)
                {
                    double temp = findDishPrice(item.ordDishID, x.listDishforBranch); // sending to func we created to find and return dish price.
                    for (int i = 0; i < item.ordDishNum; i++)
                    {
                        sumMoney += temp;
                    }
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
          if ((int)x > (int)y)//dish is less holy then order
            return true;//meaning dish isnt holy enough
          else
            return false;//meaning dish is good
        }
        
        public List<Order> chooseOrder(List<Order> orderList, Func<Order, bool> predicate = null)
        {
            var queryAllOrders = from orders in orderList
                                 where (predicate(orders))
                                 select orders;
            return (List<Order>)queryAllOrders;
        }

        #region // Not Sure how to Implement w/ Grouping
        public double moniesOrder()
        {
            throw new NotImplementedException();
        }

        public double moniesTime()
        {
            throw new NotImplementedException();
        }

        public double moniesPlace()
        {
            throw new NotImplementedException();
        }

        public bool tooYoung(Order x)
        {
            if (x.orderAge < 18)
                return true;
            else
                return false;
        }
        #endregion
        
        //EXTRA
        public double findDishPrice(int x, List<Dish> dishList)
        {
            foreach (Dish item in dishList)
            {
                if (x == item.dishID)
                    return item.dishPrice;
            }
            return 0;
        }

        public Dish mostOrderedDish(Branch x)
        {
            int counter = 0;
            Dish bestDish = null;
            foreach (Order mainItem in x.listOrderforBranch)
            {
                foreach (Ordered_Dish item in mainItem.listofOrderedDishes)
                {
                    if (item.ordDishNum > counter)
                    {
                        counter = item.ordDishNum;
                        bestDish = getDish(item.ordDishID, x.listDishforBranch);
                    }
                }
            }
            return bestDish;
        }//Finds the most ordered dish per Order
        
        public List<Dish> holierThanThou(List<Dish> dishList)
        {
            var queryHolyDish = from dish in dishList
                                where (int)dish.dishHechserDish >= 2 //he'll prefer a better hescher, but will take high.
                                select dish;
            return (List<Dish>)queryHolyDish;
        } //offers the dishes available for the holy.

        public bool tooLittleMoniesDelivery(double x)
        {
            if (x < 20)
                return true; // true that the order is too low for DELIVARY
            else
                return false;
        } // checks if order is high enough for delivery.

        public List<Dish> americanMenu(List<Dish> dishList)
        {
            var queryAmericanMenu = from dish in dishList
                                    where (int)dish.dishSizeDish >= 2 // he'll prefer a larger dish, but will take large.
                                    select dish;
            return (List<Dish>)queryAmericanMenu;
        }//Finds the menu for the Americans.

        public string managerOfTheMonth(List<Branch> branchList)
        {
            return branchSuccessMonth(branchList).branchManager;
        }//Finds the manager whose branch made the most money
      
        public Branch branchSuccessMonth(List<Branch> branchList)
        {
            double mostMoney = 0; // Highest amount of money for the Branch
            double sumOrdDishes = 0; // Sum of money from all the ordered dishes of a branch
            Branch bestBranch = null;
            foreach (Branch branchitem in branchList)
            {
                foreach (Order item in branchitem.listOrderforBranch)
                {
                    if (item.orderTime.Month == DateTime.Now.Month) // Only consider the orders made within the Month.
                        sumOrdDishes += SumMoneyDishes(branchitem);
                }
                if (sumOrdDishes > mostMoney)
                {
                    mostMoney = sumOrdDishes;
                    bestBranch = branchitem; // found the bestBranch as of now
                }
                sumOrdDishes = 0;
            }
            return bestBranch;
        } // Needs slight fixing

        public List<Branch> rankBranchPerMonth(List<Branch> branchList)
        {
            var queryWhatevra = from item in branchList
                                from item2 in item.listOrderforBranch
                                where (item2.orderTime.Month == DateTime.Now.Month)
                                orderby SumMoneyDishes(item2.listofOrderedDishes) descending
                                select item;
            return queryWhatevra.ToList<Branch>();

        }

        //FIND OUT HOW TO USE LAMBDA?!?!?!??!?!?!?!?!?!?!?
    }
}
