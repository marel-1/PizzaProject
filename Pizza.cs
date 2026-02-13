using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class Pizza : Form
    {
        public Pizza()
        {
            InitializeComponent();
        }
        private double CalculateSizePrice()
        {

            if (radiosmall.Checked == true)
            {
                return Convert.ToSingle(radiosmall.Tag);
            }
            else if (radioMeduim.Checked == true)
            {
                return Convert.ToSingle(radioMeduim.Tag);
            }
            else if(radioLarge.Checked==true)
            {
                return Convert.ToSingle(radioLarge.Tag);
            }
            else
            {
                return 0;
            }



        }
        private double CalculateCrust()
        {

            if (radioThin.Checked == true)
            {
                return Convert.ToSingle(radioThin.Tag);
            }
            else if(radioThick.Checked == true)
            {
                return Convert.ToSingle(radioThick.Tag);
            }
            else
            {
                return 0;
            }



        }
    private double CalculateToppings()
        {
            double d = 0;
            if (checkCheese.Checked == true)
            {
                d += Convert.ToSingle(checkCheese.Tag);
            }
            if (checkMushroom.Checked == true)
            {
                d += Convert.ToSingle(checkMushroom.Tag);
            }
            if (checkTomatos.Checked == true)
            {
                d += Convert.ToSingle(checkTomatos.Tag);

            }

            if (checkOnion.Checked == true)
            {
                d += Convert.ToSingle(checkOnion.Tag);
            }

            if (checkOlives.Checked == true)
            {
                d += Convert.ToSingle(checkOlives.Tag);
            }
            if (checkPeppers.Checked == true)
            {
                d += Convert.ToSingle(checkPeppers.Tag);
            }

            return d;


        }
      private void UpdatePrice()
        {
            double p = CalculateSizePrice() + CalculateToppings() + CalculateCrust();
            PriceT.Text = Convert.ToString(p);
        }
        private void UpdateSize()
        {
            UpdatePrice();
            if (radiosmall.Checked == true)
                SizeT.Text = "Small";
            else if (radioMeduim.Checked == true)
                SizeT.Text = "Meduim";
            else if (radioLarge.Checked)
                SizeT.Text = "Large";
            else
                SizeT.Text = "";


        }

       private void Updatecrust()
        {
            UpdatePrice();
            if (radioThin.Checked == true)
            {
                CrustT.Text = "Thin";
            }
            else if (radioThick.Checked == true)
            {
                CrustT.Text = "Thick";
            }
            else
            {
                CrustT.Text = "No Crust";
            }
           

        }
       void ResetOrder()
        {
            order.Enabled = true;
            Sizebox.Enabled = true;
            Crusttypebox.Enabled = true;
            ToppingsBox.Enabled = true;
            wheretoeatbox.Enabled = true;
            radiosmall.Checked = false;
            radioMeduim.Checked = false;
            radioLarge.Checked = false;
            checkCheese.Checked = false;
            checkMushroom.Checked = false;
            checkTomatos.Checked = false;
            checkOnion.Checked = false;
            checkOlives.Checked = false;
            checkPeppers.Checked = false;
            radioThin.Checked = false;
            radioThick.Checked =false;
             radioTakeOut.Checked = false;
            radioeatin.Checked = false;
            WhereToEatT.Text = "";

        }
        private void UpdateToppings()
        {
            UpdatePrice();
            string temp = "";

            if( checkCheese.Checked == true)
            {
                temp = "Extra Cheese" + ",";
               
            }
            if (checkMushroom.Checked == true)
            {
                temp = temp + "Mushroom" + ",";
            }
            if (checkTomatos.Checked == true)
            {
                temp = temp + "Tomatos\n" + ",";

            }


            if (checkOnion.Checked == true)
            {
                temp = temp + "Onion" + ",";
            }

            if (checkOlives.Checked == true)
            {
                temp = temp + "Olives" + ",\n";
            }
            if (checkPeppers.Checked == true)
            {
                temp = temp + "Green Peppers";
            }
            if (temp == "")
            {
                ToppingsT.Text = "no Toppings";
            }
            else
            {
                ToppingsT.Text = temp;
            }
        }

        private void radiosmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();

        }

        private void radioMeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();

        }

        private void radioLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();

        }

        private void radioThin_CheckedChanged(object sender, EventArgs e)
        {
            Updatecrust();
        }

        private void radioThick_CheckedChanged(object sender, EventArgs e)
        {
            Updatecrust();







        }

        private void checkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void checkMushroom_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void checkTomatos_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void checkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void checkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void checkPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void radioeatin_CheckedChanged(object sender, EventArgs e)
        {
            WhereToEatT.Text = "Eat in";
        }

        private void radioTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            WhereToEatT.Text = "Eat out";
        }

        private void order_Click(object sender, EventArgs e)
        {

          if(MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel,
              MessageBoxIcon.Question)
                == DialogResult.OK)
            {
                order.Enabled = false;
                Sizebox.Enabled = false;
                Crusttypebox.Enabled = false;
                ToppingsBox.Enabled = false;
                wheretoeatbox.Enabled = false;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            ResetOrder();
        }
    }

}