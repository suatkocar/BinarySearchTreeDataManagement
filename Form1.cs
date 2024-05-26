using Exercise2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2
{
    public partial class Form1 : Form
    {
        private BinaryTreeInt binaryTreeInt;
        private BinaryTreeCustomer binaryTreeCustomer;

        public Form1()
        {
            InitializeComponent();
            binaryTreeInt = new BinaryTreeInt();
            binaryTreeCustomer = new BinaryTreeCustomer();
        }

        private void btnInsertNumber_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxNumber.Text, out int value))
            {
                binaryTreeInt.Insert(value);
                lblTotalItemsInt.Text = "Total Items: " + binaryTreeInt.Count().ToString();
                UpdateListInt(binaryTreeInt.InOrder());
                textBoxNumber.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer");
                textBoxNumber.Clear();
            }
        }

        private void btnPreOrderInt_Click(object sender, EventArgs e)
        {
            UpdateListInt(binaryTreeInt.PreOrder());
        }

        private void btnInOrderInt_Click(object sender, EventArgs e)
        {
            UpdateListInt(binaryTreeInt.InOrder());
        }

        private void btnPostOrderInt_Click(object sender, EventArgs e)
        {
            UpdateListInt(binaryTreeInt.PostOrder());
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxName.Text) && int.TryParse(textBoxAge.Text, out int age) && !string.IsNullOrWhiteSpace(textBoxAddress.Text) && float.TryParse(textBoxAmountOwed.Text, out float amountOwed))
            {
                Customer newCustomer = new Customer
                {
                    Name = textBoxName.Text,
                    Age = age,
                    Address = textBoxAddress.Text,
                    AmountOwed = amountOwed
                };
                binaryTreeCustomer.Insert(newCustomer);
                lblTotalItemsCustomer.Text = "Total Items: " + binaryTreeCustomer.Count().ToString();
                UpdateListCustomer(binaryTreeCustomer.InOrder());
                ClearCustomerFields();
            }
            else
            {
                MessageBox.Show("Please ensure all fields are filled correctly.");
            }
        }

        private void btnFindCustomer_Click(object sender, EventArgs e)
        {
            string nameToFind = textBoxName.Text.Trim();
            if (!string.IsNullOrWhiteSpace(nameToFind))
            {
                Customer foundCustomer = binaryTreeCustomer.FindCustomer(nameToFind);
                if (foundCustomer != null)
                {
                    
                    MessageBox.Show("Customer Found: \n" + foundCustomer.GetInformation(), "Customer Details");
                }
                else
                {
                    MessageBox.Show("No customer found with the name: " + nameToFind, "Search Result");
                }
            }
                else
                {
                    MessageBox.Show("Please enter a name to search for a customer.", "Input Error");
                }
        }

        private void btnPreOrderCustomer_Click(object sender, EventArgs e)
        {
            UpdateListCustomer(binaryTreeCustomer.PreOrder());
        }

        private void btnInOrderCustomer_Click(object sender, EventArgs e)
        {
            UpdateListCustomer(binaryTreeCustomer.InOrder());
        }

        private void btnPostOrderCustomer_Click(object sender, EventArgs e)
        {
            UpdateListCustomer(binaryTreeCustomer.PostOrder());
        }
        private void ClearCustomerFields()
        {
            textBoxName.Clear();
            textBoxAge.Clear();
            textBoxAddress.Clear();
            textBoxAmountOwed.Clear();
        }
        private void UpdateListInt(List<int> items)
        {
            listBoxOutputInt.Items.Clear();
            foreach (int item in items)
            {
                listBoxOutputInt.Items.Add(item);
            }
        }

        private void UpdateListCustomer(List<string> items)
        {
            listBoxOutputCustomer.Items.Clear();
            foreach (string item in items)
            {
                listBoxOutputCustomer.Items.Add(item);
            }
        }
    }
}