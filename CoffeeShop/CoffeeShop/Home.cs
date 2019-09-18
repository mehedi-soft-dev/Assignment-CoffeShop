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
        List<string> names = new List<string> {};
        List<string> contacts = new List<string> {};
        List<string> addresses = new List<string> {};
        List<string> items = new List<string> {};

        List<int> quantities = new List<int> {};
        List<int> prices = new List<int> {};
        List<int> totalBills = new List<int> {};
        

        
        public Home()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!contacts.Contains(contactTextBox.Text) && itemComboBox.Text != "--Select One--" && !String.IsNullOrEmpty(quantityTextBox.Text))
            {
                AddCustomer(nameTextBox.Text, contactTextBox.Text, addressTextBox.Text, itemComboBox.Text, Convert.ToInt32(quantityTextBox.Text));
            }
            else
            {
                if (contacts.Contains(contactTextBox.Text))
                    MessageBox.Show("This number is already added !");
                else if (itemComboBox.Text == "--Select One--")
                    MessageBox.Show("Please Select an Item !");
                else if (String.IsNullOrEmpty(quantityTextBox.Text))
                    MessageBox.Show("Please enter quantity !");

                return;
            }

            Reset();
            ShowCustomer(names.Count - 1, names.Count);
            
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            Reset();
            ShowCustomer(0, names.Count);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void AddCustomer(string name, string contact, string address, string item,  int quantity)
        {
            int price = 0;
            if (item == "Black")
                price = 120;
            else if (item == "Cold")
                price = 100;
            else if (item == "Hot")
                price = 90;
            else if (item == "Regular")
                price = 80;

            names.Add(name);
            contacts.Add(contact);
            addresses.Add(address);
            items.Add(item);
            prices.Add(price);
            quantities.Add(quantity);
            totalBills.Add(quantity*price);

        }

        private void ShowCustomer(int startIndex, int endIndex)
        {
            
            for(int index =startIndex; index < endIndex; index++)
            {
                richTextBox.Text += "\t\tCustomer " + (index + 1) + "\n\n";
                richTextBox.Text += "Name : " + names[index] + "\n";
                richTextBox.Text += "Contact : " + contacts[index] + "\n";
                richTextBox.Text += "Address : " + addresses[index] + "\n\n";
                richTextBox.Text += "Ordered Item : " + items[index] + "\n";
                richTextBox.Text += "Price : " + prices[index] + "\n";
                richTextBox.Text += "Quantity : " + quantities[index] + "\n";
                richTextBox.Text += "Total Bill : " + totalBills[index] + "\n";
                richTextBox.Text += "----------------------------------";
            }

        }

        private void Reset()
        {
            nameTextBox.Text = "";
            contactTextBox.Text = "";
            addressTextBox.Text = "";
            itemComboBox.Text = "--Select One--";
            quantityTextBox.Text = null;
            richTextBox.Text = "";
        }

        
    }
}
