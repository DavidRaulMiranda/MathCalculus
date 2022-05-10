using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathCalculus
{
     class Calculus
    {
        OBJSetDeCalculs set;
        
        public string[] GeneraNumeRandom()
        {
            set = new OBJSetDeCalculs();
            set.numA = RandomLib.GeneraRandom(0, 10);
            set.numB = RandomLib.GeneraRandom(0, 40);
            

            return RandomToString();
        }
        public string CalculaMCD()
        {
            try
            {
                int result;
                if (AGTB(set.numA, set.numB))
                {
                    result=MCD(set.numA, set.numB);
                }
                else
                {
                    result=MCD(set.numB, set.numA);
                }
                set.MCD = result;
                return set.MCD.ToString();
            }
            catch (Exception)
            {
                return "";
            }
            
        }
        public string CalculaMCM()
        {
            try
            {
                set.MCM = (set.numA * set.numB) / set.MCD;
                return set.MCM.ToString();
            }
            catch (Exception)
            {
                return "";
            }
        }
        public string[] SetDeCalcul()
        {
            try
            {
                set.sumaNum = set.numA + set.numB;
                set.primerMenysSegon = set.numA - set.numB;
                set.segonMenysPrimer = set.numB - set.numA;
                set.multiplicacio = set.numA * set.numB;
                set.primerDivSegon =  (double)set.numA / (double)set.numB;
                set.segonDivPrimer = (double)set.numB / (double)set.numA;
                return ResultToString();
            }
            catch (Exception) //catch diferent 
            {
                return null;
            } 
        }     
        private string[] RandomToString()
        {
            string[] data = new [] { set.numA.ToString(), set.numB.ToString() };
            return data;
        }
        private string[] ResultToString()
        {
            
            List<string> print = new List<string>();
            print.Add("a+b:"+set.sumaNum.ToString());
            print.Add("a-b:"+set.primerMenysSegon.ToString());
            print.Add("b-a:"+set.segonMenysPrimer.ToString());
            print.Add("a*b:"+set.multiplicacio.ToString());
            print.Add("a/b:"+set.primerDivSegon.ToString());
            print.Add("b/a:"+set.segonDivPrimer.ToString());
            return print.ToArray();
        }
        private  bool AGTB(int a , int b)
        {
            if(a>= b)
            {
                return true;
            }
            return false;
        }
        private int MCD(int a, int b)
        {
            if (b == 0) { return a; };
            return MCD(b, a % b);
        }

    }
}
