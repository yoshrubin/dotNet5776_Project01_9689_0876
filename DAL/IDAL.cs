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
        //MUTIPLE
        List<Order> sumOrder();
        List<Dish> sumDish();
        List<Branch> sumBranch();
    }
}
