using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public enum branchHechser { normal, middle, high }; 
    public class Branch
    {
        //ctor
        public Branch(string branchName, string branchAddress, long branchPhoneNum, string branchManager, int branchEmployee, int branchDeliveryFree, branchHechser branchHechserBranch, int branchID = 0)
        {
            this.branchID = branchID;
            this.branchName = branchName;
            this.branchAddress = branchAddress;
            this.branchPhoneNum = branchPhoneNum;
            this.branchManager = branchManager;
            this.branchEmployee = branchEmployee;
            this.branchDeliveryFree = branchDeliveryFree;
            this.branchHechserBranch = branchHechserBranch;
        }
        //properties
        public int branchID { get; private set; }
        public string branchName { get; private set; }
        public string branchAddress { get; private set; }
        public long branchPhoneNum { get; private set; }
        public string branchManager { get; private set; }
        public int branchEmployee { get; private set; }
        public int branchDeliveryFree { get; private set; }
        public branchHechser branchHechserBranch { get; private set; }
        public List<Dish> listDishforBranch { get; private set; }
        public List<Order> listOrderforBranch { get; private set; }
        //functions
        public override string ToString()
        {
            string temp = null;
            temp += branchID.ToString() + " Name:" + branchName + " Address:" + branchAddress + " branch manager:" + branchManager + " branch Phone Number:" + branchPhoneNum.ToString();
            if (branchDeliveryisFree())
                temp += " the amount of delivery boys available are: " + branchDeliveryFree.ToString();
            else
                temp += " There are no delivery boys available at this time.";
            return temp;
        }
        private bool branchDeliveryisFree ()
        {
            if (branchDeliveryFree != 0)
                return true;
            else
                return false;
        }
        public void randBranchNum ()
        {
            Random r = new Random();
            branchID = r.Next(1, 1000);
        }
    }
}
