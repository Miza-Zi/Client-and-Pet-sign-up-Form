namespace Assignment_1_Code.Forms
{
    partial class Add_Pet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPetName = new System.Windows.Forms.TextBox();
            this.txtPetType = new System.Windows.Forms.TextBox();
            this.txtPetOwnerID = new System.Windows.Forms.TextBox();
            this.nudPetAge = new System.Windows.Forms.NumericUpDown();
            this.btnAddPetInForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPetAge)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Owner ID:";
            // 
            // txtPetName
            // 
            this.txtPetName.Location = new System.Drawing.Point(140, 39);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.Size = new System.Drawing.Size(100, 20);
            this.txtPetName.TabIndex = 1;
            // 
            // txtPetType
            // 
            this.txtPetType.Location = new System.Drawing.Point(140, 135);
            this.txtPetType.Name = "txtPetType";
            this.txtPetType.Size = new System.Drawing.Size(100, 20);
            this.txtPetType.TabIndex = 3;
            // 
            // txtPetOwnerID
            // 
            this.txtPetOwnerID.Location = new System.Drawing.Point(140, 186);
            this.txtPetOwnerID.Name = "txtPetOwnerID";
            this.txtPetOwnerID.Size = new System.Drawing.Size(100, 20);
            this.txtPetOwnerID.TabIndex = 4;
            // 
            // nudPetAge
            // 
            this.nudPetAge.Location = new System.Drawing.Point(140, 87);
            this.nudPetAge.Name = "nudPetAge";
            this.nudPetAge.Size = new System.Drawing.Size(100, 20);
            this.nudPetAge.TabIndex = 2;
            // 
            // btnAddPetInForm
            // 
            this.btnAddPetInForm.Location = new System.Drawing.Point(78, 229);
            this.btnAddPetInForm.Name = "btnAddPetInForm";
            this.btnAddPetInForm.Size = new System.Drawing.Size(75, 23);
            this.btnAddPetInForm.TabIndex = 5;
            this.btnAddPetInForm.Text = "Add Pet";
            this.btnAddPetInForm.UseVisualStyleBackColor = true;
            this.btnAddPetInForm.Click += new System.EventHandler(this.btnAddPet_Click);
            // 
            // Add_Pet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddPetInForm);
            this.Controls.Add(this.nudPetAge);
            this.Controls.Add(this.txtPetOwnerID);
            this.Controls.Add(this.txtPetType);
            this.Controls.Add(this.txtPetName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_Pet";
            this.Text = "Add_Pet";
            ((System.ComponentModel.ISupportInitialize)(this.nudPetAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPetName;
        private System.Windows.Forms.TextBox txtPetType;
        private System.Windows.Forms.TextBox txtPetOwnerID;
        private System.Windows.Forms.NumericUpDown nudPetAge;
        private System.Windows.Forms.Button btnAddPetInForm;
    }
}