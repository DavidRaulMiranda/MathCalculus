using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathCalculus
{
    public partial class btnMCD : Form
    {
        Calculus c = new Calculus();
        OBJSetDeCalculs d;
        public btnMCD()
        {
            InitializeComponent();
        }

   


        private void btnNumbers_Click(object sender, EventArgs e)
        {
            string[]randoms= c.GeneraNumeRandom();
            lblRndL.Text = randoms[0];
            lblRNDr.Text = randoms[1];
            lblResCMD.Text = "";
            lblResMCM.Text = "";
            lvResult.Items.Clear();
        }

        private void btnCMD_Click(object sender, EventArgs e)
        {
            if (lblRndL.Text != "")
            {
                lblResCMD.Text = c.CalculaMCD();
            }
            

        }

        private void btnMCM_Click(object sender, EventArgs e)
        {
            if (lblResCMD.Text!= "")
            {
                lblResMCM.Text = c.CalculaMCM();

            }
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            if (lblResCMD.Text != "" && lblResMCM.Text != "")
            {
                lvResult.Items.Clear();
                string[] print = c.SetDeCalcul();
                if (print != null)
                {

                    foreach (string item in print)
                    {
                        lvResult.Items.Add(item);
                    }
                }
            }
            /*
            lvResult.Items.Add("a+b: "+d.sumaNum.ToString());
            lvResult.Items.Add("a-b: " + d.primerMenysSegon.ToString());
            lvResult.Items.Add("b-a: " + d.segonMenysPrimer.ToString());
            lvResult.Items.Add("a*b: " + d.multiplicacio.ToString());
            lvResult.Items.Add("a/b: " + d.primerDivSegon.ToString());
            lvResult.Items.Add("b/a: " + d.segonDivPrimer.ToString());
            */

        }
    }
}
