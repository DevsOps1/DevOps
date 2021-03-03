using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Calculatrice
{
    public class calc
    {
        public calc()
        {
        }

        public int add(int a, int b)
        {
            return a + b;
        }

        public int moins(int a, int b)
        {
            return a - b;
        }
        public int Multi(int a, int b)
        {
            return a * b;
        }
        public int div(int a, int b)
        {
            return a / b;
        }

        public int modulo(int a, int b)
        {
            return a % b;
        }

        public bool paireImpaire(int a)
        {
            bool result = false;
            if(a % 2 == 0)
            {
                 result = true;
            }
         return result;  
        }
       

        public bool Premier(int a)
        {
            bool result = true;
            for (int i = 2; i<a-1; i++)
            {
                if(a%i == 0)
                {
                    result = false; 
                }

            }
            return result;
        }
    }
}
