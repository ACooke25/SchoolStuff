using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAC_1_Task_1
{
    public partial class Form1 : Form
    {
        float cumulative = 0f;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate(float age, float price)
        {
            float depreciation = (float)(age * 0.2 * price);
            float total;




            if (depreciation > price)
            {
                lblWorth.Text = "This textbook is worth $0";
            }
            else
            {

                total = (price - depreciation);
                cumulative = cumulative + total;
                lblWorth.Text = ("This textbook is worth $" + total);
                lblCollectionWorth.Text = ("The collection so far is worth $" + cumulative);
                ResetText();
            }
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            calculate(float.Parse(numAge.Text), float.Parse(numTextbookPrice.Text));
        }

        private void btnEndQuote_Click(object sender, EventArgs e)
        {
            numTextbookPrice.Value = 0;
            numAge.Value = 0;
            lblWorth.Text = " ";
            lblCollectionWorth.Text = " ";

        }
    }
}
