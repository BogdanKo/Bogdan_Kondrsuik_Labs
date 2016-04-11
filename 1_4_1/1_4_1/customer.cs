using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4_1
{
    class customer
    {
        // 6) declare private field name
        private string name;


        // 7) declare constructor to initialize name

        public customer(string Customername)
        {
            Customername = name;
        }


        // 8) declare method GotNewGoods with 2 parameters:
        // 1 - object type
        // 2 - GoodsInfoEventArgs type

        public void GotNewGoods(object sender, GoodsInfoEventArgs s)
        {

        }
    }
}
