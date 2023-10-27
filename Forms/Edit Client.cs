using Assignment_1_Code.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace Assignment_1_Code.Forms
{
    public partial class Edit_Client : Form
    {

        public Edit_Client(BindingList<PetClass> petList)
        {
            InitializeComponent();
            _petList = petList;
        }


        // Create a Public object which can be accessed by other forms
        public ClientClass cellToEdit;

        private BindingList<PetClass> _petList;

        private void btnEditClientInForm_Click_1(object sender, EventArgs e)
        {
            // Input validation 
            if (txtFirstName.Text != "" && txtLastName.Text != "" && txtIDNumber.Text != "")
            {
                // Get the old client ID
                string oldClientID = cellToEdit.IDNumber;

                // Update the client's properties
                cellToEdit.Name = txtFirstName.Text;
                cellToEdit.Surname = txtLastName.Text;
                cellToEdit.IDNumber = txtIDNumber.Text;
                cellToEdit.CreditLimit = Convert.ToInt32(nudCreditLimit.Value);

                // Update the IDs of all pets owned by this client in the pet list
                foreach (PetClass pet in _petList)
                {
                    if (pet.OwnerID == oldClientID)
                    {
                        pet.OwnerID = txtIDNumber.Text;
                    }
                }

                // Close the form
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all the fields!");
            }
        }


        private void Edit_Client_Load(object sender, EventArgs e)
        {

            txtFirstName.Text = cellToEdit.Name;
            txtLastName.Text = cellToEdit.Surname;
            txtIDNumber.Text = cellToEdit.IDNumber;
            nudCreditLimit.Value =(decimal) cellToEdit.CreditLimit;

        }
    }


}

