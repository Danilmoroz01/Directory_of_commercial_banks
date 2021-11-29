namespace Directory_of_commercial_banks
{
    partial class userForm
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.label2 = new System.Windows.Forms.Label();
            this.poisktext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.directory_of_commercial_banksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(146, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список банков";
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
            this.tableAdapterManager.DepartmentTableAdapter = null;
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
            this.bankDataGridView.Location = new System.Drawing.Point(24, 91);
            this.bankDataGridView.Name = "bankDataGridView";
            this.bankDataGridView.RowTemplate.Height = 24;
            this.bankDataGridView.Size = new System.Drawing.Size(547, 220);
            this.bankDataGridView.TabIndex = 2;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(638, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 43);
            this.label2.TabIndex = 3;
            // 
            // poisktext
            // 
            this.poisktext.Location = new System.Drawing.Point(635, 91);
            this.poisktext.Multiline = true;
            this.poisktext.Name = "poisktext";
            this.poisktext.Size = new System.Drawing.Size(195, 42);
            this.poisktext.TabIndex = 4;
            this.poisktext.TextChanged += new System.EventHandler(this.poisktexta_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(635, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.poisktext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bankDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "userForm";
            this.Text = "userForm";
            this.Load += new System.EventHandler(this.userForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.directory_of_commercial_banksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox poisktext;
        private System.Windows.Forms.Button button1;
    }
}