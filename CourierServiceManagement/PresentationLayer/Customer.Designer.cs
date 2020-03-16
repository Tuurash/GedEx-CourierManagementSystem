namespace CourierServiceManagement.PresentationLayer
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.dgvAll = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSubmitted = new MetroFramework.Controls.MetroButton();
            this.LblWelcome = new MetroFramework.Controls.MetroLabel();
            this.LblName = new MetroFramework.Controls.MetroLabel();
            this.BtnDelivered = new MetroFramework.Controls.MetroButton();
            this.BtnNwOrder = new MetroFramework.Controls.MetroButton();
            this.BtnLogout = new MetroFramework.Controls.MetroButton();
            this.BtnDlt = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAll
            // 
            this.dgvAll.AllowUserToAddRows = false;
            this.dgvAll.AllowUserToDeleteRows = false;
            this.dgvAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvAll.Location = new System.Drawing.Point(23, 116);
            this.dgvAll.Name = "dgvAll";
            this.dgvAll.ReadOnly = true;
            this.dgvAll.Size = new System.Drawing.Size(516, 257);
            this.dgvAll.TabIndex = 0;
            this.dgvAll.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAll_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 79;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "productName";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 79;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Condition";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 79;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Address";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 79;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "RecieverNumber";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 78;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "SenderNumber";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 79;
            // 
            // BtnSubmitted
            // 
            this.BtnSubmitted.Location = new System.Drawing.Point(23, 383);
            this.BtnSubmitted.Name = "BtnSubmitted";
            this.BtnSubmitted.Size = new System.Drawing.Size(109, 49);
            this.BtnSubmitted.TabIndex = 1;
            this.BtnSubmitted.Text = "Submitted";
            this.BtnSubmitted.UseSelectable = true;
            this.BtnSubmitted.Click += new System.EventHandler(this.BtnSubmitted_Click);
            // 
            // LblWelcome
            // 
            this.LblWelcome.AutoSize = true;
            this.LblWelcome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblWelcome.Location = new System.Drawing.Point(118, 60);
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(55, 25);
            this.LblWelcome.Style = MetroFramework.MetroColorStyle.Black;
            this.LblWelcome.TabIndex = 4;
            this.LblWelcome.Text = "Hello,";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LblName.Location = new System.Drawing.Point(179, 60);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(59, 25);
            this.LblName.TabIndex = 5;
            this.LblName.Text = "name";
            // 
            // BtnDelivered
            // 
            this.BtnDelivered.Location = new System.Drawing.Point(138, 383);
            this.BtnDelivered.Name = "BtnDelivered";
            this.BtnDelivered.Size = new System.Drawing.Size(123, 49);
            this.BtnDelivered.TabIndex = 7;
            this.BtnDelivered.Text = "Show Deliverd Percels";
            this.BtnDelivered.UseSelectable = true;
            this.BtnDelivered.Click += new System.EventHandler(this.BtnDelivered_Click);
            // 
            // BtnNwOrder
            // 
            this.BtnNwOrder.Location = new System.Drawing.Point(452, 63);
            this.BtnNwOrder.Name = "BtnNwOrder";
            this.BtnNwOrder.Size = new System.Drawing.Size(87, 44);
            this.BtnNwOrder.TabIndex = 8;
            this.BtnNwOrder.Text = "New Order";
            this.BtnNwOrder.UseSelectable = true;
            this.BtnNwOrder.Click += new System.EventHandler(this.BtnNwOrder_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.Location = new System.Drawing.Point(464, 383);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(75, 51);
            this.BtnLogout.TabIndex = 9;
            this.BtnLogout.Text = "Log Out";
            this.BtnLogout.UseSelectable = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnDlt
            // 
            this.BtnDlt.Location = new System.Drawing.Point(336, 63);
            this.BtnDlt.Name = "BtnDlt";
            this.BtnDlt.Size = new System.Drawing.Size(110, 44);
            this.BtnDlt.TabIndex = 10;
            this.BtnDlt.Text = "Delete Submission";
            this.BtnDlt.UseSelectable = true;
            this.BtnDlt.Click += new System.EventHandler(this.BtnDlt_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 457);
            this.Controls.Add(this.BtnDlt);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.BtnNwOrder);
            this.Controls.Add(this.BtnDelivered);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblWelcome);
            this.Controls.Add(this.BtnSubmitted);
            this.Controls.Add(this.dgvAll);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customer";
            this.Resizable = false;
            this.Text = "Customer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Customer_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAll;
        private MetroFramework.Controls.MetroButton BtnSubmitted;
        private MetroFramework.Controls.MetroLabel LblWelcome;
        private MetroFramework.Controls.MetroLabel LblName;
        private MetroFramework.Controls.MetroButton BtnDelivered;
        private MetroFramework.Controls.MetroButton BtnNwOrder;
        private MetroFramework.Controls.MetroButton BtnLogout;
        private MetroFramework.Controls.MetroButton BtnDlt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}