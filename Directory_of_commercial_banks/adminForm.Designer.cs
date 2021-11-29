namespace Directory_of_commercial_banks
{
    partial class adminForm
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
            this.directory_of_commercial_banksDataSet = new Directory_of_commercial_banks.directory_of_commercial_banksDataSet();
            this.bankBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankTableAdapter = new Directory_of_commercial_banks.directory_of_commercial_banksDataSetTableAdapters.BankTableAdapter();
            this.tableAdapterManager = new Directory_of_commercial_banks.directory_of_commercial_banksDataSetTableAdapters.TableAdapterManager();
            this.bankDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new Directory_of_commercial_banks.directory_of_commercial_banksDataSetTableAdapters.DepartmentTableAdapter();
            this.departmentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.directory_of_commercial_banksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // directory_of_commercial_banksDataSet
            // 
            this.directory_of_commercial_banksDataSet.DataSetName = "directory_of_commercial_banksDataSet";
            this.directory_of_commercial_banksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankBindingSource
            // 
            this.bankBindingSource.DataMember = "Bank";
            this.bankBindingSource.DataSource = this.directory_of_commercial_banksDataSet;
            // 
            // bankTableAdapter
            // 
            this.bankTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BankTableAdapter = this.bankTableAdapter;
            this.tableAdapterManager.DepartmentTableAdapter = this.departmentTableAdapter;
            this.tableAdapterManager.OperationsTableAdapter = null;
            this.tableAdapterManager.OwnerTableAdapter = null;
            this.tableAdapterManager.PropertyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Directory_of_commercial_banks.directory_of_commercial_banksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // bankDataGridView
            // 
            this.bankDataGridView.AutoGenerateColumns = false;
            this.bankDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bankDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.bankDataGridView.DataSource = this.bankBindingSource;
            this.bankDataGridView.Location = new System.Drawing.Point(23, 31);
            this.bankDataGridView.Name = "bankDataGridView";
            this.bankDataGridView.RowTemplate.Height = 24;
            this.bankDataGridView.Size = new System.Drawing.Size(545, 220);
            this.bankDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.HeaderText = "name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn2.HeaderText = "email";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "phone_number";
            this.dataGridViewTextBoxColumn3.HeaderText = "phone_number";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "selling_rate";
            this.dataGridViewTextBoxColumn4.HeaderText = "selling_rate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "owner";
            this.dataGridViewTextBoxColumn5.HeaderText = "owner";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.directory_of_commercial_banksDataSet;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // departmentDataGridView
            // 
            this.departmentDataGridView.AutoGenerateColumns = false;
            this.departmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.departmentDataGridView.DataSource = this.departmentBindingSource;
            this.departmentDataGridView.Location = new System.Drawing.Point(608, 31);
            this.departmentDataGridView.Name = "departmentDataGridView";
            this.departmentDataGridView.RowTemplate.Height = 24;
            this.departmentDataGridView.Size = new System.Drawing.Size(644, 220);
            this.departmentDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "adress";
            this.dataGridViewTextBoxColumn6.HeaderText = "adress";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "bank_name";
            this.dataGridViewTextBoxColumn7.HeaderText = "bank_name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "contact_information";
            this.dataGridViewTextBoxColumn8.HeaderText = "contact_information";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "currency_balance";
            this.dataGridViewTextBoxColumn9.HeaderText = "currency_balance";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "city";
            this.dataGridViewTextBoxColumn10.HeaderText = "city";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn11.HeaderText = "id";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(608, 355);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 34);
            this.button4.TabIndex = 7;
            this.button4.Text = "Изменить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(608, 314);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 34);
            this.button5.TabIndex = 6;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(608, 273);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 34);
            this.button6.TabIndex = 5;
            this.button6.Text = "Добавить";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.departmentDataGridView);
            this.Controls.Add(this.bankDataGridView);
            this.Name = "adminForm";
            this.Text = "adminForm";
            this.Load += new System.EventHandler(this.adminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.directory_of_commercial_banksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private directory_of_commercial_banksDataSet directory_of_commercial_banksDataSet;
        private System.Windows.Forms.BindingSource bankBindingSource;
        private directory_of_commercial_banksDataSetTableAdapters.BankTableAdapter bankTableAdapter;
        private directory_of_commercial_banksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bankDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private directory_of_commercial_banksDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.DataGridView departmentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}