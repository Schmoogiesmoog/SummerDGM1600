
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPPizzaOrder
{
    public partial class pizzaOrderForm : Form
    {
        public pizzaOrderForm()
        {
            InitializeComponent();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            // Variables
            string crusttype = "";
            string topping1 = "";
            string topping2 = "";
            string topping3 = "";
            string city = "";
            string finalorder = "";

            // Test the radio buttons
            if(panRadioButton.Checked)
            {
                crusttype = panRadioButton.Text;
            }
            else
            {
                crusttype = thinRadioButton.Text;
            }

            // Test the three different check boxes to see if they are checked
            if(cheeseCheckBox.Checked)
            {
                topping1 = cheeseCheckBox.Text;
            }

            if(pepperoniCheckBox.Checked)
            {
                topping2 = pepperoniCheckBox.Text;
            }

            if(pinneappleCheckBox.Checked)
            {
                topping3 = pinneappleCheckBox.Text;
            }

            // Find the selected city in the list box
            if(cityListBox.SelectedIndex != -1)
            {
                city = cityListBox.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Please select a city for delivery.");
            }

            // Place order
            finalorder = crusttype + " " + "crust " + topping1 + " " + topping2 + " " + topping3 + " " + "delivered to " + city;

            // Display the order
            orderResultsLabel.Text = finalorder;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            cheeseCheckBox.Checked = false;
            pepperoniCheckBox.Checked = false;
            pinneappleCheckBox.Checked = false;
            orderResultsLabel.Text = "";
            cityListBox.ClearSelected();
        }
    }
}
