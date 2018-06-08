using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FredsIceCreamShop
{
    public partial class Form1 : Form
    {
        bool sundaeOrdered = false;
        bool sodaOrdered = false;
        private double _totalPrice;

        public Form1()
        {
            InitializeComponent();
            _totalPrice = 0;

            nameErrorLabel.Text = "";
            sodaErrorLabel.Text = "";
            sundaeErrorLabel.Text = "";
            priceLabel.Text = "";


            sprinklesCheckBox.Enabled = false;
            nutsCheckBox.Enabled = false;
            choclateCheckBox.Enabled = false;

            limeCheckBox.Enabled = false;
            peachCheckBox.Enabled = false;
            mangoCheckBox.Enabled = false;
        }
        
        private void sundaeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sundaeCheckBox.Checked)
            {
                sprinklesCheckBox.Enabled = true;
                sprinklesCheckBox.BackColor = Color.LightBlue;
                nutsCheckBox.Enabled = true;
                nutsCheckBox.BackColor = Color.LightBlue;
                choclateCheckBox.Enabled = true;
                choclateCheckBox.BackColor = Color.LightBlue;
                sundaeOrdered = true;
            }
            else if (sundaeCheckBox.Checked == false)
            {
                sprinklesCheckBox.Enabled = false;
                sprinklesCheckBox.BackColor = default(Color);
                nutsCheckBox.Enabled = false;
                nutsCheckBox.BackColor = default(Color);
                choclateCheckBox.Enabled = false;
                choclateCheckBox.BackColor = default(Color);
                sundaeOrdered = true;
                sprinklesCheckBox.Checked = false;
                nutsCheckBox.Checked = false;
                choclateCheckBox.Checked = false;
            }
        }

        private void sodaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sodaCheckBox.Checked)
            {
                limeCheckBox.Enabled = true;
                limeCheckBox.BackColor = Color.LightBlue;
                peachCheckBox.Enabled = true;
                peachCheckBox.BackColor = Color.LightBlue;
                mangoCheckBox.Enabled = true;
                mangoCheckBox.BackColor = Color.LightBlue;
                sodaOrdered = true;
            }
            else if (sundaeCheckBox.Checked == false)
            {
                limeCheckBox.Enabled = true;
                limeCheckBox.BackColor = default(Color);
                peachCheckBox.Enabled = true;
                limeCheckBox.BackColor = default(Color);
                mangoCheckBox.Enabled = true;
                limeCheckBox.BackColor = default(Color);
                sodaOrdered = true;
                limeCheckBox.Checked = false;
                peachCheckBox.Checked = false;
                mangoCheckBox.Checked = false;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Order newOrder;
            nameErrorLabel.Text = "";
            nameErrorLabel.BackColor = default(Color);
            sundaeErrorLabel.Text = "";
            sodaErrorLabel.Text = "";
            try
            {
                newOrder = new Order(nameTextBox.Text, sundaeOrdered, sodaOrdered);
                if (sundaeOrdered == true)
                {
                    if (sprinklesCheckBox.Checked)
                    {
                        newOrder.Sundae.AddTopping(SundaeTopping.SPRINKLES);
                    }
                    if (nutsCheckBox.Checked)
                    {
                        newOrder.Sundae.AddTopping(SundaeTopping.NUTS);
                    }
                    if (choclateCheckBox.Checked)
                    {
                        newOrder.Sundae.AddTopping(SundaeTopping.CHOCOLSTE_SYRUP);
                    }
                }

                if (sodaOrdered == true)
                {
                    if (limeCheckBox.Checked)
                    {
                        newOrder.Soda.AddFlavor(SodaFlavor.LIME);
                    }
                    if (peachCheckBox.Checked)
                    {
                        newOrder.Soda.AddFlavor(SodaFlavor.PEACH);
                    }
                    if (mangoCheckBox.Checked)
                    {
                        newOrder.Soda.AddFlavor(SodaFlavor.MANGO);
                    }
                }

                recieptTextBox.Text += newOrder.ToString();
                _totalPrice += newOrder.Price;
                priceLabel.Text = String.Format("Total: {0:C}", _totalPrice);
            }
            catch (NameMissing ex)
            {
                nameErrorLabel.Text = ex.Message;
                nameErrorLabel.BackColor = Color.Red;
            }
            catch (NoFood ex)
            {
                nameErrorLabel.Text = ex.Message;
                nameErrorLabel.BackColor = Color.Red;
            }
            catch (TooManyToppings ex)
            {
                sundaeErrorLabel.Text = ex.Message;
                sundaeErrorLabel.BackColor = Color.Red;
            }
            catch (TooManyFlavors ex)
            {
                sodaErrorLabel.Text = ex.Message;
                sodaErrorLabel.BackColor = Color.Red;
            }
        }

    }
}
