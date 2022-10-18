using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadaca_18_10_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int annualSallary = 55000;
            SallaryCalc(annualSallary);
            SallaryCalc((double)annualSallary);
            
        }

        void SallaryCalc(int sallary)
        {
            int calculation = sallary / 52;
            lblCalcReturn.Text += String.Format("\nZa godišnju plaću od {0:0.00}, tjedna plaća iznosi: {1:0.00} kn.", sallary.ToString("C"), calculation);
              //  "Za godišnju plaću od " + sallary + " kn, " + " Tjedna plaća iznosi: " + calculation.ToString() + "\n";
        }
        void SallaryCalc(double sallary)
        {
            double calculation = sallary / 52;
            lblCalcReturn.Text += String.Format("\nZa godišnju plaću od {0:0.00}, tjedna plaća iznosi: {1:0.00} kn.", sallary.ToString("C"), calculation);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            lblReturnOrder.Text = string.Empty;
            
            int brojLadica;
            string vrstaDrva = "";
            Ladice(out brojLadica);
            VrstaDrva(ref vrstaDrva);
            int cijena;
            CijenaStola(vrstaDrva, brojLadica, out cijena);

            lblReturnOrder.Text += String.Format("\nNaručili ste {0} stol s {1} ladice.", vrstaDrva,brojLadica);
            lblReturnOrder.Text += String.Format("\nUkupna cijena iznosi: {0:0.00} kn.", cijena);

        }
        public void Ladice (out int brojLadica)
        {
            brojLadica = Convert.ToInt32(txtDrawers.Text);
        }
        public void VrstaDrva(ref string vrstaDrva)
        {
            if (txtWoodTyp.Text == "H" || txtWoodTyp.Text == "h")
                vrstaDrva = "hrastov";
            if (txtWoodTyp.Text == "B" || txtWoodTyp.Text == "b")
                vrstaDrva = "borov";
            if (txtWoodTyp.Text == "J" || txtWoodTyp.Text == "j")
                vrstaDrva = "javorov";

        }
        public void CijenaStola(string vrstaDrva, int brojLadica, out int cijena)
        {
            cijena = 0;
            if (vrstaDrva == "hrastov")
                cijena = 140 + brojLadica * 30;
            if (vrstaDrva == "borov")
                cijena = 100 + brojLadica * 30;
            if (vrstaDrva == "javorov")
                cijena = 180 + brojLadica * 30;
            
        }
    }
}
