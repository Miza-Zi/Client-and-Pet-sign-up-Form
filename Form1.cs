
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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Assignment_1_Code.Forms;
using System.Runtime.InteropServices.ComTypes;

namespace Assignment_1_Code
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            dgvClient.CellClick += dgvClient_CellClick;
        }

        public void UpdatePetDataGridView()
        {
            dgvPet.Refresh();
        }


        //Global BindingList
        private BindingList<ClientClass> clientList = new BindingList<ClientClass>(); // Create a list to store clients
        private BindingList<PetClass> petList = new BindingList<PetClass>(); // list to store pet

        // Serialization and Deserialization methods for clientList
        public void SerializeClientList()
        {
            FileStream outFile = new FileStream("ClientList.ser", FileMode.Create, FileAccess.Write);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(outFile, clientList);
            outFile.Close();
        }

        public void DeserializeClientList()
        {
            try
            {
                FileStream inFile = new FileStream("ClientList.ser", FileMode.Open, FileAccess.Read);
                BinaryFormatter bFormatter = new BinaryFormatter();
                clientList.Clear();
                var tempList = (BindingList<ClientClass>)bFormatter.Deserialize(inFile);
                foreach (ClientClass myObject in tempList)
                {
                    clientList.Add(myObject);
                }
                inFile.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No Client List was saved");
            }
        }

        // Serialization and Deserialization methods for petList
        public void SerializePetList()
        {
            FileStream outFile = new FileStream("PetList.ser", FileMode.Create, FileAccess.Write);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(outFile, petList);
            outFile.Close();
        }

        public void DeserializePetList()
        {
            try
            {
                FileStream inFile = new FileStream("PetList.ser", FileMode.Open, FileAccess.Read);
                BinaryFormatter bFormatter = new BinaryFormatter();
                petList.Clear();
                var tempList = (BindingList<PetClass>)bFormatter.Deserialize(inFile);
                foreach (PetClass myObject in tempList)
                {
                    petList.Add(myObject);
                }
                inFile.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No Pet List was saved");
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            //assign bindingList s the datasource for the datagridview
            dgvClient.DataSource = clientList;
            dgvPet.DataSource = petList;

            // Load clientList from serialization
            DeserializeClientList();

            // Load petList from serialization
            DeserializePetList();

        }
        private void btnAddClient_Click(object sender, EventArgs e)
        {

            //Create an instance of the form
            Add_Client addClientForm = new Add_Client();

            //show the form
            addClientForm.ShowDialog();

            clientList.Add(addClientForm.clientToAdd);

            SerializeClientList();

        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            

            // Get the selected row index of the DataGridView
            int selectedIndex = dgvClient.CurrentCell.RowIndex;

            // Create  object to be EDITED
            ClientClass clientToEdit = clientList[selectedIndex]; // using the BindingList index values
            ClientClass clientToEdit1 = (ClientClass)dgvClient.Rows[selectedIndex].DataBoundItem;
            
            //Instance 
            Edit_Client editClientForm = new Edit_Client(petList);

            // setting
            editClientForm.cellToEdit = clientToEdit;

            editClientForm.ShowDialog();
            
            // Update the row in  BindingList 
            clientList[selectedIndex] = editClientForm.cellToEdit;

            SerializeClientList();


        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            
            //instance
            Add_Pet addPetForm = new Add_Pet();

            //show 
            addPetForm.ShowDialog();

            petList.Add(addPetForm.petToAdd);

            SerializePetList();
        }


        private void btnEditPet_Click(object sender, EventArgs e)
        {
            int SelectedIndex = dgvPet.CurrentCell.RowIndex;

            PetClass petToEdit = petList[SelectedIndex];
            PetClass petToEdit1 = (PetClass)dgvPet.Rows[SelectedIndex].DataBoundItem;
            
            //instance
            Edit_Pet editPetForm = new Edit_Pet(clientList);

            editPetForm.PetListReference = petList; // Set the PetListReference property


            //setting
            editPetForm.editPetCell = petToEdit;


            editPetForm.ShowDialog();

            petList[SelectedIndex] = editPetForm.editPetCell;
            SerializePetList();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dgvClient.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgvClient.SelectedRows[0];

                // Get the index of the selected row
                int selectedIndex = selectedRow.Index;

                // Remove the corresponding client from the list
                if (selectedIndex >= 0 && selectedIndex < clientList.Count)
                {
                    ClientClass cellToRemove = clientList[selectedIndex];

                    // Change the OwnerID of pets belonging to the deleted client
                    foreach (PetClass pet in petList)
                    {
                        if (pet.OwnerID == cellToRemove.IDNumber)
                        {
                            pet.OwnerID = "NO OWNER";
                            SerializeClientList();
                        }
                    }

                    clientList.Remove(cellToRemove);

                    SerializeClientList();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDeletePet_Click(object sender, EventArgs e)
        {
            // check for row selection
            if(dgvPet.SelectedRows.Count > 0)
            {
                //get index row
                DataGridViewRow selecetedRow = dgvPet.SelectedRows[0];

                int SelectedIndex = selecetedRow.Index;

                // remove corresponding client on the list
                if(SelectedIndex >= 0 && SelectedIndex < petList.Count)
                {
                    PetClass rowToRemove = petList[SelectedIndex];
                    petList.Remove(rowToRemove);

                    SerializePetList();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a cell in the client DataGridView is clicked
            if (e.RowIndex >= 0 && e.RowIndex < dgvClient.Rows.Count)
            {
                // Get the selected client from the clicked cell
                DataGridViewRow selectedRow = dgvClient.Rows[e.RowIndex];
                ClientClass selectedClient = (ClientClass)selectedRow.DataBoundItem;

                // Filter the pet list to get pets belonging to the selected client
                var selectedClientPets = petList.Where(pet => pet.OwnerID == selectedClient.IDNumber).ToList();

                // Check if the selected client has pets
                if (selectedClientPets.Count > 0)
                {
                    // Bind the selected client's pets to dgvOwnerPet and make it visible
                    dgvOwnerPet.DataSource = selectedClientPets;
                    dgvOwnerPet.Visible = true;
                }
                else
                {
                    // If the selected client has no pets, hide dgvOwnerPet
                    dgvOwnerPet.Visible = false;
                }
            }
        }

        private decimal purchaseAmount = 0.0M; // Declare a class-level variable to store the total purchase amount
        private void btnMakePurchase_Click(object sender, EventArgs e)
        {
            decimal purchase = nudPurchaseAmount.Value;

            if (purchase <= 0)
            {
                MessageBox.Show("Purchase amount must be greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the selected client
            int selectedIndex = dgvClient.CurrentCell.RowIndex;
            ClientClass selectedClient = clientList[selectedIndex];

            // Calculate the remaining credit limit
            decimal remainingCredit = selectedClient.CreditLimit - purchase;

            if (remainingCredit < purchase)
            {
                MessageBox.Show("Purchase amount exceeds the client's remaining credit limit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Deduct the purchase amount from the credit limit
            selectedClient.CreditLimit -= purchase;

            // Update the total purchase amount
            purchaseAmount += purchase;

            // Update the Current Balance Owed column in the DataGridView
            selectedClient.CurrentBalanceOwed += purchase;

            // Refresh the DataGridView
            dgvClient.Refresh();

            SerializeClientList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            decimal payment = nudPaymentAmount.Value;

            if (payment <= 0)
            {
                MessageBox.Show("Payment amount must be greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the selected client
            int selectedIndex = dgvClient.CurrentCell.RowIndex;
            ClientClass selectedClient = clientList[selectedIndex];

            if (payment > selectedClient.CurrentBalanceOwed)
            {
                MessageBox.Show("Payment amount exceeds the client's current balance owed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Deduct the payment amount from the current balance owed
            selectedClient.CurrentBalanceOwed -= payment;

            // Update the credit limit if necessary (e.g., if the payment brings the balance owed below the credit limit)
            if (selectedClient.CurrentBalanceOwed < selectedClient.CreditLimit)
            {
                selectedClient.CreditLimit = selectedClient.CurrentBalanceOwed;
            }

            // Refresh the DataGridView
            dgvClient.Refresh();

            SerializeClientList();
        }

        public void UpdateClientOwnerID(string oldOwnerID, string newOwnerID)
        {
            foreach (ClientClass client in clientList)
            {
                if (client.IDNumber == oldOwnerID)
                {
                    client.IDNumber = newOwnerID;
                }
            }

            // Update the DataGridView to reflect the changes
            dgvClient.Refresh();
        }
    }


}

