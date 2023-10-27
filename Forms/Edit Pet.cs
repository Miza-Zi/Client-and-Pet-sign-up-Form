using Assignment_1_Code.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace Assignment_1_Code.Forms
{
    public partial class Edit_Pet : Form
    {
        public Edit_Pet(BindingList<ClientClass> clientList)
        {
            InitializeComponent();
            _clientList = clientList;
        }


        public PetClass editPetCell;

        private BindingList<ClientClass> _clientList;

        // Property to store a reference to the petList
        public BindingList<PetClass> PetListReference { get; set; }


        private void btnEditPetInForm_Click(object sender, EventArgs e)
        {
            if (txtNameForPet.Text != "" && txtTypeOfPet.Text != "" && txtOwnerId.Text != "")
            {
                // Get the old pet owner's ID
                string oldOwnerID = editPetCell.OwnerID;

                // Get the new owner ID
                string newOwnerID = txtOwnerId.Text;

                // Update the pet's properties
                editPetCell.Name = txtNameForPet.Text;
                editPetCell.Type = txtTypeOfPet.Text;
                editPetCell.OwnerID = newOwnerID;

                // Update the OwnerID of other pets with the same ID
                foreach (PetClass pet in PetListReference)
                {
                    if (pet.OwnerID == oldOwnerID)
                    {
                        pet.OwnerID = txtOwnerId.Text;
                    }
                }

                // Update the client's ID in dgvClient
                MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
                if (mainForm != null)
                {
                    mainForm.UpdateClientOwnerID(oldOwnerID, newOwnerID);
                }

                // Update the DataGridView in MainForm
                mainForm.UpdatePetDataGridView();

                // Close the form
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all the fields!");
            }
        }





        private void Edit_Pet_Load(object sender, EventArgs e)
        {
            txtNameForPet.Text = editPetCell.Name;
            txtTypeOfPet.Text = editPetCell.Type;
            txtOwnerId.Text = editPetCell.OwnerID;
            nudAgeForPet.Value = (decimal)editPetCell.Age;
        }
    }
}
