using System;
using Assignment_1_Code.Classes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1_Code.Forms
{
    public partial class Add_Client : Form
    {
        

        public Add_Client()
        {
            InitializeComponent();
            
        }

        //Create a public instance that can be accessed 
        public ClientClass clientToAdd = new ClientClass();

        private void btnaddClientInTheForm_Click_1(object sender, EventArgs e)
        {
            //Input validation 
            if (txtFirstName.Text != "" && txtLastName.Text != "" && txtIDNumber.Text != "")
            {
                //set the public product objects equalto users unput
                clientToAdd.Name = txtFirstName.Text;
                clientToAdd.Surname = txtLastName.Text;
                clientToAdd.IDNumber = (txtIDNumber.Text);
                clientToAdd.CreditLimit = Convert.ToInt32(nudCreditLimit.Value);

                //Close form
                this.Close();

            }
            else
            {
                MessageBox.Show("Please fill in all the fields!");
            }
        }
    }
}
