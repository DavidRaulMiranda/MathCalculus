using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathCalculus
{
     public class Calculus
    {
        public OBJSetDeCalculs set;
        
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
        public List<int> SetDeCalcul()
        {
            List<int> resultats = new List<int>();
            try
            {
                resultats.Add(set.numA + set.numB);
                resultats.Add(set.numA - set.numB);
                resultats.Add(set.numB - set.numA);
                if(set.numA * set.numB > 300)
                {
                    return null;
                }
                resultats.Add(set.numA * set.numB);
                resultats.Add(set.numA / set.numB);
                resultats.Add(set.numB / set.numA);
                return resultats;
            }
            catch (DivideByZeroException) //catch diferent 
            {
                MessageBox.Show("Attempted to divide by zero");
                return null;
            } 
        }     
        private string[] RandomToString()
        {
            string[] data = new [] { set.numA.ToString(), set.numB.ToString() };
            return data;
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
