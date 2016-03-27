using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usr_Exception
{
    #region Opr
    class Bird
    {
        public int[] FlySpeed = { 5, 15, 25, 35 };
        public int NormalSpeed { get; set; }
        public string NickName { get; set; }
        public bool BirdFlewAway;

        public Bird() { }

        public Bird(string NickName, int NormalSpeed)
        {

            this.NickName = NickName;
            this.NormalSpeed = NormalSpeed;

        }

        public void FlyAway(int incrmnt)
        {

            if (BirdFlewAway)
                Console.WriteLine("Bird {0}", NickName + " flew away");

            else
            {
                NormalSpeed += incrmnt;
                if (NormalSpeed >= FlySpeed[3])
                {
                    BirdFlewAway = true;
                    NormalSpeed = 0;
                    BirdFlewAwayException ex = new BirdFlewAwayException(string.Format("{0}flew with incredible speed!",
                        NickName), "Oh! Startle.", DateTime.Now);

                    ex.HelpLink = "http://en.wikipedia.org/wiki/Tufted_titmiuse";

                    throw ex;

                }
                else
                {
                    Console.WriteLine("{0} bird flying speed is about normal", NickName);

                }

            }
        }
    }
}
        #endregion
   
