using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public interface IDAL
    {
        //DISH
        void addDish(Dish x);
        void deleteDish(Dish x);
        void updateDish(Dish x);
        //ORDER
        void addOrder(Order x);
        void deleteOrder(Order x);
        void updateOrder(Order x);
        //Ordered-Dish
        void addOrdDish(Ordered_Dish x);
        void updateOrdDish(Ordered_Dish x);
        void deleteOrdDish(Ordered_Dish x);
        //BRANCH
        void addBranch(Branch x);
        void deleteBranch(Branch x);
        void updateBranch(Branch x);
        //MUTIPLE
        void sumOrder(List<Order> x);
        void sumDish(List<Dish> x);
        void sumBranch(List<Branch> x);
    }

    public class DAL
    {
    }
}
