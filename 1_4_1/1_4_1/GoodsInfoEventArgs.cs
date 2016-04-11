using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4_1
{
    class GoodsInfoEventArgs: EventArgs

    {
        // 2) declare property GoodsName
        // think about get and set attributes

        public string GoodsName { get; set; }
        public float GoodsCost { get; set; }



        // 3) declare constructor to initialize GoodsName
        public GoodsInfoEventArgs(string goodsname, float cost)
        {

            goodsname = GoodsName;
            cost = GoodsCost;

        }
    }
}
