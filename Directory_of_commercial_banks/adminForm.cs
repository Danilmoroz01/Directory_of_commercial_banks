using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Directory_of_commercial_banks
{
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
        }

        private void bankBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bankBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.directory_of_commercial_banksDataSet);

        }

        private void adminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "directory_of_commercial_banksDataSet.Department". При необходимости она может быть перемещена или удалена.
            this.departmentTableAdapter.Fill(this.directory_of_commercial_banksDataSet.Department);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "directory_of_commercial_banksDataSet.Bank". При необходимости она может быть перемещена или удалена.
            this.bankTableAdapter.Fill(this.directory_of_commercial_banksDataSet.Bank);

        }
    }
}
