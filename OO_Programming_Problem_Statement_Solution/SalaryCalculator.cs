using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Programming_Problem_Statement_Solution
{
    public class SalaryCalculator
    {
        public static float calculateAllowance(int experience,float basic)
        {
            float allowance = 0;
            if(experience <= 2)
            {
                allowance = (30 * basic) / 100;
            }
            else if (experience <= 4)
            {
                allowance = (40 * basic) / 100;
            }
            else if (experience <= 6)
            {
                allowance = (50 * basic) / 100;
            }
            else if (experience >6)
            {
                allowance = (65 * basic) / 100;
            }
            return allowance;
        } 
    }
}
