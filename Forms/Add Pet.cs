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
    public partial class Add_Pet : Form
    {
        public Add_Pet()
        {
            InitializeComponent();
        }

        public PetClass petToAdd = new PetClass();


        private void btnAddPet_Click(object sender, EventArgs e)
        {
            //Input validation 
            if (txtPetName.Text != "" && txtPetType.Text != "" && txtPetOwnerID.Text != "")
            {
                //set the public product objects equalto users unput
                petToAdd.Name = txtPetName.Text;
                petToAdd.Type = txtPetType.Text;
                petToAdd.OwnerID = (txtPetOwnerID.Text);
                petToAdd.Age = Convert.ToInt32(nudPetAge.Value);

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
