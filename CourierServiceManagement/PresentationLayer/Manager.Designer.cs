namespace CourierServiceManagement.PresentationLayer
{
    partial class Manager
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.btnDelivered = new MetroFramework.Controls.MetroButton();
            this.btnViewEmp = new MetroFramework.Controls.MetroButton();
            this.btnNewEmp = new MetroFramework.Controls.MetroButton();
            this.btnAll = new MetroFramework.Controls.MetroButton();
            this.btnViewCustomer = new MetroFramework.Controls.MetroButton();
            this.btnPending = new MetroFramework.Controls.MetroButton();
            this.courierServiceDBDataSet5 = new CourierServiceManagement.CourierServiceDBDataSet5();
            this.productDbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDbTableAdapter = new CourierServiceManagement.CourierServiceDBDataSet5TableAdapters.ProductDbTableAdapter();
            this.dgvAll = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.courierServiceDBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelivered
            // 
            this.btnDelivered.Location = new System.Drawing.Point(32, 173);
            this.btnDelivered.Name = "btnDelivered";
            this.btnDelivered.Size = new System.Drawing.Size(129, 44);
            this.btnDelivered.TabIndex = 17;
            this.btnDelivered.Text = "Order Delivered";
            this.btnDelivered.UseSelectable = true;
            this.btnDelivered.Click += new System.EventHandler(this.btnDelivered_Click);
            // 
            // btnViewEmp
            // 
            this.btnViewEmp.Location = new System.Drawing.Point(32, 329);
            this.btnViewEmp.Name = "btnViewEmp";
            this.btnViewEmp.Size = new System.Drawing.Size(129, 45);
            this.btnViewEmp.TabIndex = 16;
            this.btnViewEmp.Text = "View Employee";
            this.btnViewEmp.UseSelectable = true;
            this.btnViewEmp.Click += new System.EventHandler(this.btnViewEmp_Click);
            // 
            // btnNewEmp
            // 
            this.btnNewEmp.Location = new System.Drawing.Point(32, 279);
            this.btnNewEmp.Name = "btnNewEmp";
            this.btnNewEmp.Size = new System.Drawing.Size(129, 44);
            this.btnNewEmp.TabIndex = 15;
            this.btnNewEmp.Text = "New employee";
            this.btnNewEmp.UseSelectable = true;
            this.btnNewEmp.Click += new System.EventHandler(this.btnNewEmp_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(32, 223);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(129, 50);
            this.btnAll.TabIndex = 14;
            this.btnAll.Text = "All Products";
            this.btnAll.UseSelectable = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnViewCustomer
            // 
            this.btnViewCustomer.Location = new System.Drawing.Point(32, 124);
            this.btnViewCustomer.Name = "btnViewCustomer";
            this.btnViewCustomer.Size = new System.Drawing.Size(129, 43);
            this.btnViewCustomer.TabIndex = 13;
            this.btnViewCustomer.Text = "View Customer";
            this.btnViewCustomer.UseSelectable = true;
            this.btnViewCustomer.Click += new System.EventHandler(this.btnViewCustomer_Click);
            // 
            // btnPending
            // 
            this.btnPending.Location = new System.Drawing.Point(32, 81);
            this.btnPending.Name = "btnPending";
            this.btnPending.Size = new System.Drawing.Size(129, 37);
            this.btnPending.TabIndex = 12;
            this.btnPending.Text = "Pending Order";
            this.btnPending.UseSelectable = true;
            this.btnPending.Click += new System.EventHandler(this.btnPending_Click);
            // 
            // courierServiceDBDataSet5
            // 
            this.courierServiceDBDataSet5.DataSetName = "CourierServiceDBDataSet5";
            this.courierServiceDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productDbBindingSource
            // 
            this.productDbBindingSource.DataMember = "ProductDb";
            this.productDbBindingSource.DataSource = this.courierServiceDBDataSet5;
            // 
            // productDbTableAdapter
            // 
            this.productDbTableAdapter.ClearBeforeFill = true;
            // 
            // dgvAll
            // 
            this.dgvAll.AllowUserToAddRows = false;
            this.dgvAll.AllowUserToDeleteRows = false;
            this.dgvAll.AllowUserToResizeRows = false;
            this.dgvAll.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAll.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAll.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAll.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAll.EnableHeadersVisualStyles = false;
            this.dgvAll.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAll.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAll.Location = new System.Drawing.Point(167, 81);
            this.dgvAll.Name = "dgvAll";
            this.dgvAll.ReadOnly = true;
            this.dgvAll.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAll.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAll.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAll.Size = new System.Drawing.Size(570, 289);
            this.dgvAll.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Percel Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Condition";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Address";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "ReciverNumber";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "SenderNumber";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(640, 376);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(97, 41);
            this.btnLogout.TabIndex = 19;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 440);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.dgvAll);
            this.Controls.Add(this.btnDelivered);
            this.Controls.Add(this.btnViewEmp);
            this.Controls.Add(this.btnNewEmp);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnViewCustomer);
            this.Controls.Add(this.btnPending);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manager";
            this.Resizable = false;
            this.Text = "Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manager_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.courierServiceDBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnDelivered;
        private MetroFramework.Controls.MetroButton btnViewEmp;
        private MetroFramework.Controls.MetroButton btnNewEmp;
        private MetroFramework.Controls.MetroButton btnAll;
        private MetroFramework.Controls.MetroButton btnViewCustomer;
        private MetroFramework.Controls.MetroButton btnPending;
        private CourierServiceDBDataSet5 courierServiceDBDataSet5;
        private System.Windows.Forms.BindingSource productDbBindingSource;
        private CourierServiceDBDataSet5TableAdapters.ProductDbTableAdapter productDbTableAdapter;
        private MetroFramework.Controls.MetroGrid dgvAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private MetroFramework.Controls.MetroButton btnLogout;
    }
}