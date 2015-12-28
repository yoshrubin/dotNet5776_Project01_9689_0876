using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace DS
{
    //fix
    class Dal_imp : DataSource, IDAL
    {
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

        public bool updateOrder(Order x,List<Order> orderList)
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
    }
}
