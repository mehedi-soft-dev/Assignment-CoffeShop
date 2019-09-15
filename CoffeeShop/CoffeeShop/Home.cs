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

        const int size = 10;

        string[] name = new string[size];
        string[] contact = new string[size];
        string[] address = new string[size];
        string[] item = new string[size];

        int[] quantity = new int[size];
        int[] price = new int[size];
        int[] totalBill = new int[size];


        int index = 0;

        public Home()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(index < size)
            {
                if(itemComboBox.Text != "--Select One--")
                {
                    name[index] = nameTextBox.Text;
                    contact[index] = contactTextBox.Text;
                    address[index] = addressTextBox.Text;
                    item[index] = itemComboBox.Text;

                    if (item[index]=="Black")
                        price[index] = 120;
                    else if (item[index] == "Cold")
                        price[index] = 100;
                    else if (item[index] == "Hot")
                        price[index] = 90;
                    else if (item[index] == "Regular")
                        price[index] = 80;

                    quantity[index] = Convert.ToInt32(quantityTextBox.Text);
                    totalBill[index] = price[index] * quantity[index];

                    
                    richTextBox.Text += "\t\tCustomer " + (index + 1) +"\n\n";
                    richTextBox.Text += "Name : " +name[index] + "\n";
                    richTextBox.Text += "Contact : " +contact[index] + "\n";
                    richTextBox.Text += "Address : " +address[index] + "\n\n";
                    richTextBox.Text += "Ordered Item : " +item[index] + "\n";
                    richTextBox.Text += "Price : " +price[index] + "\n";
                    richTextBox.Text += "Quantity : " +quantity[index] +"\n";
                    richTextBox.Text += "Total Bill : " +totalBill[index] + "\n";
                    richTextBox.Text += "----------------------------------";

                    index++;

                }
                else
                {
                    MessageBox.Show("Please Select an Item !");
                }
            }
            else
            {
                MessageBox.Show("Maximum Customer added !!");
            }
            

        }
    }
}
