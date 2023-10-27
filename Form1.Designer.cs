namespace Assignment_1_Code
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.clientPage = new System.Windows.Forms.TabPage();
            this.dgvOwnerPet = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPurchase = new System.Windows.Forms.Label();
            this.nudPurchaseAmount = new System.Windows.Forms.NumericUpDown();
            this.btnMakePurchase = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPaymentAmount = new System.Windows.Forms.Label();
            this.nudPaymentAmount = new System.Windows.Forms.NumericUpDown();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.IDNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Petpage = new System.Windows.Forms.TabPage();
            this.dgvPet = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeletePet = new System.Windows.Forms.Button();
            this.btnEditPet = new System.Windows.Forms.Button();
            this.btnAddPet = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.clientPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwnerPet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPurchaseAmount)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaymentAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.Petpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.clientPage);
            this.tabControl1.Controls.Add(this.Petpage);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(857, 529);
            this.tabControl1.TabIndex = 0;
            // 
            // clientPage
            // 
            this.clientPage.Controls.Add(this.dgvOwnerPet);
            this.clientPage.Controls.Add(this.label1);
            this.clientPage.Controls.Add(this.btnDeleteClient);
            this.clientPage.Controls.Add(this.btnEditClient);
            this.clientPage.Controls.Add(this.btnAddClient);
            this.clientPage.Controls.Add(this.groupBox2);
            this.clientPage.Controls.Add(this.groupBox1);
            this.clientPage.Controls.Add(this.dgvClient);
            this.clientPage.Location = new System.Drawing.Point(4, 22);
            this.clientPage.Name = "clientPage";
            this.clientPage.Padding = new System.Windows.Forms.Padding(3);
            this.clientPage.Size = new System.Drawing.Size(849, 503);
            this.clientPage.TabIndex = 0;
            this.clientPage.Text = "Client";
            this.clientPage.UseVisualStyleBackColor = true;
            // 
            // dgvOwnerPet
            // 
            this.dgvOwnerPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOwnerPet.Location = new System.Drawing.Point(254, 357);
            this.dgvOwnerPet.Name = "dgvOwnerPet";
            this.dgvOwnerPet.Size = new System.Drawing.Size(422, 134);
            this.dgvOwnerPet.TabIndex = 9;
            this.dgvOwnerPet.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Click on the client to view their pets";
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Location = new System.Drawing.Point(7, 122);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteClient.TabIndex = 3;
            this.btnDeleteClient.Text = "Delete Client";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.Location = new System.Drawing.Point(7, 67);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(75, 23);
            this.btnEditClient.TabIndex = 2;
            this.btnEditClient.Text = "Edit Client";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(7, 11);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(75, 23);
            this.btnAddClient.TabIndex = 1;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPurchase);
            this.groupBox2.Controls.Add(this.nudPurchaseAmount);
            this.groupBox2.Controls.Add(this.btnMakePurchase);
            this.groupBox2.Location = new System.Drawing.Point(468, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 182);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Capture Client Purchase";
            // 
            // txtPurchase
            // 
            this.txtPurchase.AutoSize = true;
            this.txtPurchase.Location = new System.Drawing.Point(38, 49);
            this.txtPurchase.Name = "txtPurchase";
            this.txtPurchase.Size = new System.Drawing.Size(94, 13);
            this.txtPurchase.TabIndex = 2;
            this.txtPurchase.Text = "Purchase Amount:";
            // 
            // nudPurchaseAmount
            // 
            this.nudPurchaseAmount.Location = new System.Drawing.Point(170, 42);
            this.nudPurchaseAmount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPurchaseAmount.Name = "nudPurchaseAmount";
            this.nudPurchaseAmount.ReadOnly = true;
            this.nudPurchaseAmount.Size = new System.Drawing.Size(120, 20);
            this.nudPurchaseAmount.TabIndex = 1;
            // 
            // btnMakePurchase
            // 
            this.btnMakePurchase.Location = new System.Drawing.Point(41, 96);
            this.btnMakePurchase.Name = "btnMakePurchase";
            this.btnMakePurchase.Size = new System.Drawing.Size(75, 35);
            this.btnMakePurchase.TabIndex = 5;
            this.btnMakePurchase.Text = "Make Purchase";
            this.btnMakePurchase.UseVisualStyleBackColor = true;
            this.btnMakePurchase.Click += new System.EventHandler(this.btnMakePurchase_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPaymentAmount);
            this.groupBox1.Controls.Add(this.nudPaymentAmount);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Location = new System.Drawing.Point(148, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 182);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Capture Client Payment";
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.AutoSize = true;
            this.txtPaymentAmount.Location = new System.Drawing.Point(47, 46);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(90, 13);
            this.txtPaymentAmount.TabIndex = 2;
            this.txtPaymentAmount.Text = "Payment Amount:";
            // 
            // nudPaymentAmount
            // 
            this.nudPaymentAmount.Location = new System.Drawing.Point(168, 42);
            this.nudPaymentAmount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPaymentAmount.Name = "nudPaymentAmount";
            this.nudPaymentAmount.ReadOnly = true;
            this.nudPaymentAmount.Size = new System.Drawing.Size(120, 20);
            this.nudPaymentAmount.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(50, 102);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvClient
            // 
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDNumber,
            this.FirstName,
            this.LastName,
            this.creditLimit,
            this.currentBalance});
            this.dgvClient.Location = new System.Drawing.Point(148, 27);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.Size = new System.Drawing.Size(634, 134);
            this.dgvClient.TabIndex = 2;
            // 
            // IDNumber
            // 
            this.IDNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IDNumber.DataPropertyName = "IDnumber";
            this.IDNumber.HeaderText = "ID Number";
            this.IDNumber.Name = "IDNumber";
            this.IDNumber.Width = 77;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "Name";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "Surname";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            // 
            // creditLimit
            // 
            this.creditLimit.DataPropertyName = "CreditLimit";
            this.creditLimit.HeaderText = "Credit Limit";
            this.creditLimit.Name = "creditLimit";
            // 
            // currentBalance
            // 
            this.currentBalance.DataPropertyName = "CurrentBalanceOwed";
            this.currentBalance.HeaderText = "Current Balance";
            this.currentBalance.Name = "currentBalance";
            // 
            // Petpage
            // 
            this.Petpage.Controls.Add(this.dgvPet);
            this.Petpage.Controls.Add(this.btnDeletePet);
            this.Petpage.Controls.Add(this.btnEditPet);
            this.Petpage.Controls.Add(this.btnAddPet);
            this.Petpage.Location = new System.Drawing.Point(4, 22);
            this.Petpage.Name = "Petpage";
            this.Petpage.Padding = new System.Windows.Forms.Padding(3);
            this.Petpage.Size = new System.Drawing.Size(849, 503);
            this.Petpage.TabIndex = 1;
            this.Petpage.Text = "Pet ";
            this.Petpage.UseVisualStyleBackColor = true;
            // 
            // dgvPet
            // 
            this.dgvPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvPet.Location = new System.Drawing.Point(148, 18);
            this.dgvPet.Name = "dgvPet";
            this.dgvPet.Size = new System.Drawing.Size(461, 134);
            this.dgvPet.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "age";
            this.dataGridViewTextBoxColumn2.HeaderText = "Age";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn3.HeaderText = "Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ownerID";
            this.dataGridViewTextBoxColumn4.HeaderText = "Owner ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // btnDeletePet
            // 
            this.btnDeletePet.Location = new System.Drawing.Point(6, 129);
            this.btnDeletePet.Name = "btnDeletePet";
            this.btnDeletePet.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePet.TabIndex = 8;
            this.btnDeletePet.Text = "Delete Pet";
            this.btnDeletePet.UseVisualStyleBackColor = true;
            this.btnDeletePet.Click += new System.EventHandler(this.btnDeletePet_Click);
            // 
            // btnEditPet
            // 
            this.btnEditPet.Location = new System.Drawing.Point(6, 74);
            this.btnEditPet.Name = "btnEditPet";
            this.btnEditPet.Size = new System.Drawing.Size(75, 23);
            this.btnEditPet.TabIndex = 7;
            this.btnEditPet.Text = "Edit Pet";
            this.btnEditPet.UseVisualStyleBackColor = true;
            this.btnEditPet.Click += new System.EventHandler(this.btnEditPet_Click);
            // 
            // btnAddPet
            // 
            this.btnAddPet.Location = new System.Drawing.Point(6, 18);
            this.btnAddPet.Name = "btnAddPet";
            this.btnAddPet.Size = new System.Drawing.Size(75, 23);
            this.btnAddPet.TabIndex = 6;
            this.btnAddPet.Text = "Add Pet";
            this.btnAddPet.UseVisualStyleBackColor = true;
            this.btnAddPet.Click += new System.EventHandler(this.btnAddPet_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(914, 544);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.clientPage.ResumeLayout(false);
            this.clientPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwnerPet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPurchaseAmount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaymentAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.Petpage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage clientPage;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.TabPage Petpage;
        private System.Windows.Forms.Label txtPaymentAmount;
        private System.Windows.Forms.NumericUpDown nudPaymentAmount;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtPurchase;
        private System.Windows.Forms.NumericUpDown nudPurchaseAmount;
        private System.Windows.Forms.Button btnMakePurchase;
        private System.Windows.Forms.DataGridView dgvPet;
        private System.Windows.Forms.Button btnDeletePet;
        private System.Windows.Forms.Button btnEditPet;
        private System.Windows.Forms.Button btnAddPet;
        private System.Windows.Forms.DataGridView dgvOwnerPet;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

