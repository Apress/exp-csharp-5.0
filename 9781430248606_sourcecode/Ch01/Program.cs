using System;                                   /* importing namespace */

namespace Ch01                                  /* namespace declaration */
{
    class Program                               /* class declaration*/
    {
        static void Main(string[] args)         /* method declaration */
        {
            PowerGenerator pg = new PowerGenerator();
            pg.ProcessPower();
        }                                       /* end of method declaration */
    }                                           /* end of class declaration */

    public class PowerGenerator
    {
        const int limit = 3;                    /* constant declaration */
        const string
                  original = "Original number",
                  square = "Square number";

        public void ProcessPower()
        {
            Console.WriteLine("{0,16}{1,20}",
                    original, square); 	        /* statement*/
            for (int i = 0; i <= limit; ++i)    /* iteration statement*/
            {
                Console.Write("{0,10}{1,20}\n", i, Math.Pow(i, 2));
            }
        }
    }
}                                           /* end of namespace declaration */
