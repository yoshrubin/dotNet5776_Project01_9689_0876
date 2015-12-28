using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DS;
using BE;


namespace BL
{
    public interface IBL
    {
        //fix
        //DISH
        bool addDish(Dish x, List<Dish> dishList);
        bool deleteDish(int x, List<Dish> dishList);
        bool updateDish(Dish x, List<Dish> dishList);
        Dish getDish(int dishID, List<Dish> dishList);
        //ORDER
        bool addOrder(Order x, List<Order> orderList);
        bool deleteOrder(int x, List<Order> orderList);
        bool updateOrder(Order x, List<Order> orderList);
        Order getOrder(int orderID, List<Order> orderList);
        //Ordered-Dish
        bool addOrdDish(Ordered_Dish x, List<Ordered_Dish> ordDishList);
        bool updateOrdDish(Ordered_Dish x, List<Ordered_Dish> ordDishList);
        bool deleteOrdDish(int x, List<Ordered_Dish> ordDishList);
        Ordered_Dish getOrdDish(int OrdDishID, List<Ordered_Dish> ordDishList);
        //BRANCH
        bool addBranch(Branch x, List<Branch> branchList);
        bool deleteBranch(int x, List<Branch> branchList);
        bool updateBranch(Branch x, List<Branch> branchList);
        Branch getBranch(int branchID, List<Branch> branchList);
        //EXTRA
        double SumMoneyDishes(Branch x);
        Dish mostOrderedDish(Branch x);
        bool tooLittleMoniesDelivery(double x);
        List<Dish> holierThanThou(List<Dish> dishList);
        bool tooMuchMonies(double x);
        bool tooLittleHoly(orderHechser x, dishHechser y);
        List<Order> chooseOrder(List<Order> orderList, Func<Order, bool> predicate = null);
        double moniesTime();
        double moniesPlace();
        bool tooYoung(Order x); // Need to get age.
        List<Dish> americanMenu(List<Dish> dishList);
        string managerOfTheMonth(List<Branch> branchList);
        Branch branchSuccessMonth(List<Branch> branchList);
        List<Branch> rankBranchPerMonth(List<Branch> branchList);
    }
    public class BL
    {
    }
}
