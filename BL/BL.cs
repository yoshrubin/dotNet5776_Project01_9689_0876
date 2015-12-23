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
        //DISH
        bool addDish(Dish x);
        bool deleteDish(int x);
        bool updateDish(Dish x);
        Dish getDish(int dishID);
        //ORDER
        bool addOrder(Order x);
        bool deleteOrder(int x);
        bool updateOrder(Order x);
        Order getOrder(int orderID);
        //Ordered-Dish
        bool addOrdDish(Ordered_Dish x);
        bool updateOrdDish(Ordered_Dish x);
        bool deleteOrdDish(int x);
        Ordered_Dish getOrdDish(int OrdDishID);
        //BRANCH
        bool addBranch(Branch x);
        bool deleteBranch(int x);
        bool updateBranch(Branch x);
        Branch getBranch(int branchID);
        //MUTIPLE
        List<Order> sumOrder();
        List<Dish> sumDish();
        List<Branch> sumBranch();
        //EXTRA
        double SumMoneyDishes(List<Ordered_Dish> x);
        bool tooMuchMonies(double x);
        bool tooLittleHoly(orderHechser x, dishHechser y);
        List<Order> chooseOrder(Func<Order, bool> predicate = null); // verify
        double moniesOrder();
        double moniesTime();
        double moniesPlace();
        bool tooYoung(Order x); // Need to get age.
    }
    public class BL
    {
    }
}
