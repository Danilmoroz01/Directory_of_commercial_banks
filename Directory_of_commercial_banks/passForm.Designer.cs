namespace Directory_of_commercial_banks
{
    partial class passForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loginField = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.directory_of_commercial_banksDataSet = new Directory_of_commercial_banks.directory_of_commercial_banksDataSet();
            this.bankBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankTableAdapter = new Directory_of_commercial_banks.directory_of_commercial_banksDataSetTableAdapters.BankTableAdapter();
            this.tableAdapterManager = new Directory_of_commercial_banks.directory_of_commercial_banksDataSetTableAdapters.TableAdapterManager();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new Directory_of_commercial_banks.directory_of_commercial_banksDataSetTableAdapters.UserTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directory_of_commercial_banksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(288, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Авторизация";
            // 
            // loginField
            // 
            this.loginField.Location = new System.Drawing.Point(19, 162);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(212, 42);
            this.loginField.TabIndex = 3;
            // 
            // passField
            // 
            this.passField.Location = new System.Drawing.Point(19, 271);
            this.passField.Multiline = true;
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(212, 42);
            this.passField.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "Еще нет аккаунта?";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.directory_of_commercial_banksDataSet;
            this.bindingSource1.Position = 0;
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
            this.tableAdapterManager.UserTableAdapter = this.userTableAdapter;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.directory_of_commercial_banksDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "adminForm";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.adminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directory_of_commercial_banksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private directory_of_commercial_banksDataSet directory_of_commercial_banksDataSet;
        private System.Windows.Forms.BindingSource bankBindingSource;
        private directory_of_commercial_banksDataSetTableAdapters.BankTableAdapter bankTableAdapter;
        private directory_of_commercial_banksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private directory_of_commercial_banksDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.BindingSource userBindingSource;
    }
}

