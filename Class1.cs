using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class Class1
    {
        public double ans;
        public double add(double a,double b)
        {
            ans = a + b;
            return ans;
        }
        public double sub(double a, double b)
        {
            ans = a - b;
            return ans;
        }
        public double mult(double a, double b)
        {
            ans = a * b;
            return ans;
        }
        public double div(double a, double b)
        {
            if(b!=0){
            ans = a / b;
           
            }
            else
            {

            }
            return ans;
        }
    }
}
