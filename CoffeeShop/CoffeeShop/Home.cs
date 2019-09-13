using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            String customerName, contact, address, order, item;
            int quantity, price, totalBill;

            customerName = nameTextBox.Text;
            contact = contactTextBox.Text;
            address = addressTextBox.Text;
            order = orderComboBox.Text;
            quantity = Convert.ToInt32(quantityTextBox.Text);
            item = orderComboBox.Text;

            if (orderComboBox.Text == "Black")
                price = 120;
            else if (orderComboBox.Text == "Cold")
                price = 100;
            else if (orderComboBox.Text == "Hot")
                price = 90;
            else
               price = 80;

            totalBill = price * quantity;

            if (orderComboBox.Text == "--Select One--")
                MessageBox.Show("Please Select an Item !!!");
            else
                richTextBox.Text = "\nCustomer Name :  " + customerName + "\n" + "Contact No.        :  " + contact + "\n" + "Address             :  " + address + "\n\n\n" + "Ordered Item :  " + orderComboBox.Text + "\n"+"Price              :  "+price+"\n" + "Quantity        :  " + quantity + "\n" + "Total Bill        :  " + totalBill + "\n";


        }
    }
}
