using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4_1
{
    class Program
    {
        static void Main()
        {
            // 9) declare object of OnlineShop 

            OnlineShop MyShop = new OnlineShop();

            // 10) declare several objects of Customer
            customer c1 = new customer("Jake");
            customer c2 = new customer("Mary");
            customer c3 = new customer("Ron");
            customer c4 = new customer("Bill");



            // 11) subscribe method GotNewGoods() of every Customer instance 
            MyShop.s += c1.GotNewGoods;
            MyShop.s += c2.GotNewGoods;
            MyShop.s += c3.GotNewGoods;
            MyShop.s += c4.GotNewGoods;

            // to event NewGoodsInfo of object of OnlineShop


            // 12) invoke method NewGoods() of object of OnlineShop
            // discuss results

            MyShop.NewGoods("Samsung", 2340);
            MyShop.NewGoods("Apple", 18000);
            MyShop.NewGoods("Intel", 7000);
            MyShop.NewGoods("NVidia", 4000);

        }
    }
}
