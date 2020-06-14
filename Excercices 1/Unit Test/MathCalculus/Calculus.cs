using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathCalculus
{
    public class Calculus
    {
        public int num1 { get; set; }
        public int num2 { get; set; }

        public Calculus()
        {
            Random random = new Random();

            this.num1 = random.Next(0,11);
            this.num2 = random.Next(0,41);
        }

        public Calculus(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public int MCD()
        {
            int a = Math.Max(num1, num2);
            int b = Math.Min(num1, num2);
           
            int mcd;

            do
            {
                try
                {
                    mcd = b;
                    b = a % b;
                    a = mcd;
                }
                catch (Exception)
                {
                    mcd = 0;
                }
            }
            while (b != 0);

            return mcd;
        }

        public int MCM ()
        {
            int min = Math.Min(num1, num2);
            int mcd, mcm = 0;

            for (int i = 1; i <= min; i++)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    mcd = i;
                    mcm = (num1 * num2) / mcd;
                }
            }

            return mcm; 
        }

        public List<int> results()
        {
            List<int> listRes = new List<int>();

            if(num1 * num2 < 300)
            {
                listRes.Add(num1 + num2);
                listRes.Add(num1 - num2);
                listRes.Add(num2 - num1);
                listRes.Add(num1 * num2);
                
                if (num1 == 0 || num2 == 0)
                {
                    listRes.Add(0);
                    listRes.Add(0);
                }
                else
                {
                    listRes.Add(num1/num2);
                    listRes.Add(num2/num1);
                }
            }

            return listRes; 

        }
    }
}
