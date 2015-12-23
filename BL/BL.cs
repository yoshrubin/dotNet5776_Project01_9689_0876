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
        void addDish(Dish x);
        void deleteDish(int x);
        void updateDish(Dish x);
        //ORDER
        void addOrder(Order x);
        void deleteOrder(int x);
        void updateOrder(Order x);
        //Ordered-Dish
        void addOrdDish(Ordered_Dish x);
        void updateOrdDish(Ordered_Dish x);
        void deleteOrdDish(int x);
        //BRANCH
        void addBranch(Branch x);
        void deleteBranch(int x);
        void updateBranch(Branch x);
        //MUTIPLE
        void sumOrder(List<Order> x);
        void sumDish(List<Dish> x);
        void sumBranch(List<Branch> x);
        //EXTRA
        double SumMoneyDishes(List<Ordered_Dish> x);
        bool tooMuchMonies(double x);
        bool tooLittleHoly(orderHechser x, dishHechser y);
        List<Order> chooseOrder(List<Order> x, Func<Order, bool> predicate); // verify
        double moniesOrder(List<Dish> x);
        double moniesTime(List<Order> x);
        double moniesPlace(List<Branch> x);
        bool tooYoung(Order x); // Need to get age.


    }
    public class BL
    {
    }
}
