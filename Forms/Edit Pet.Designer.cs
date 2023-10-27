namespace Assignment_1_Code.Forms
{
    partial class Edit_Pet
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
            this.nudAgeForPet = new System.Windows.Forms.NumericUpDown();
            this.txtOwnerId = new System.Windows.Forms.TextBox();
            this.txtTypeOfPet = new System.Windows.Forms.TextBox();
            this.txtNameForPet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditPetInForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAgeForPet)).BeginInit();
            this.SuspendLayout();
            // 
            // nudAgeForPet
            // 
            this.nudAgeForPet.Location = new System.Drawing.Point(126, 60);
            this.nudAgeForPet.Name = "nudAgeForPet";
            this.nudAgeForPet.Size = new System.Drawing.Size(100, 20);
            this.nudAgeForPet.TabIndex = 16;
            // 
            // txtOwnerId
            // 
            this.txtOwnerId.Location = new System.Drawing.Point(126, 160);
            this.txtOwnerId.Name = "txtOwnerId";
            this.txtOwnerId.Size = new System.Drawing.Size(100, 20);
            this.txtOwnerId.TabIndex = 13;
            // 
            // txtTypeOfPet
            // 
            this.txtTypeOfPet.Location = new System.Drawing.Point(126, 108);
            this.txtTypeOfPet.Name = "txtTypeOfPet";
            this.txtTypeOfPet.Size = new System.Drawing.Size(100, 20);
            this.txtTypeOfPet.TabIndex = 14;
            // 
            // txtNameForPet
            // 
            this.txtNameForPet.Location = new System.Drawing.Point(126, 12);
            this.txtNameForPet.Name = "txtNameForPet";
            this.txtNameForPet.Size = new System.Drawing.Size(100, 20);
            this.txtNameForPet.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Owner ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Age:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name:";
            // 
            // btnEditPetInForm
            // 
            this.btnEditPetInForm.Location = new System.Drawing.Point(68, 204);
            this.btnEditPetInForm.Name = "btnEditPetInForm";
            this.btnEditPetInForm.Size = new System.Drawing.Size(75, 23);
            this.btnEditPetInForm.TabIndex = 17;
            this.btnEditPetInForm.Text = "Edit Pet";
            this.btnEditPetInForm.UseVisualStyleBackColor = true;
            this.btnEditPetInForm.Click += new System.EventHandler(this.btnEditPetInForm_Click);
            // 
            // Edit_Pet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditPetInForm);
            this.Controls.Add(this.nudAgeForPet);
            this.Controls.Add(this.txtOwnerId);
            this.Controls.Add(this.txtTypeOfPet);
            this.Controls.Add(this.txtNameForPet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Edit_Pet";
            this.Text = "Edit_Pet";
            this.Load += new System.EventHandler(this.Edit_Pet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAgeForPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudAgeForPet;
        private System.Windows.Forms.TextBox txtOwnerId;
        private System.Windows.Forms.TextBox txtTypeOfPet;
        private System.Windows.Forms.TextBox txtNameForPet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditPetInForm;
    }
}