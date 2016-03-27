using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usr_Exception
{
    class Program
    {
        static void Main()


        {
            Console.WriteLine("Observation titmouse flight");
            Bird my_Bird = new Bird("Titmouse", 20);

            byte ii;
            char sdk;
            try
            {
                do
                {
                    try
                    {

                        Console.WriteLine("Monitoring in try block");
                        Console.WriteLine(@"Please, type the number
                                 1.array overflow;
                                 2.throw exception;
                                 3.user exception; 

                             ");
                        uint i = uint.Parse(Console.ReadLine());

                        switch (i)
                        {
                            case 1:

                                int j = my_Bird.FlySpeed[5];
                                break;

                            case 2:
                                throw (new SystemException());

                            case 3:

                                for (ii = 0; ii < my_Bird.NormalSpeed; ii++)
                                {
                                    my_Bird.FlyAway(ii);
                                }
                                break;
                            default:
                                break;
                        }

                    }

                    catch (BirdFlewAwayException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine(ex.When);
                        Console.WriteLine(ex.Why);
                    }

                    catch (SystemException e)
                    {
                        Console.WriteLine("CLS exception: Message -  " + e.Message + " Source - " + e.Source);
                    }

                    finally
                    {
                        Console.WriteLine("For the next step..");
                    }
                    Console.WriteLine("Press SpaceBar to exit application");

                    sdk = Console.ReadKey().KeyChar;
                }

                while (sdk != ' ');

            }

            catch (Exception mn)
            {

            }
        

        }

    }
}











