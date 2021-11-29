using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Directory_of_commercial_banks
{
    public partial class userForm : Form
    {
        public userForm()
        {
            InitializeComponent();
        }

        private void bankBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bankBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.directory_of_commercial_banksDataSet);

        }

        private void userForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "directory_of_commercial_banksDataSet.Bank". При необходимости она может быть перемещена или удалена.
            this.bankTableAdapter.Fill(this.directory_of_commercial_banksDataSet.Bank);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source = DESKTOP-BTPASGH; Initial Catalog = directory_of_commercial_banks; Integrated Security = True";
                connection.Open();

                string poisktexta = poisktext.Text;
                using (SqlCommand command = new SqlCommand($"SELECT * FROM Bank where name = '{poisktexta}' OR owner = '{poisktexta}';", connection))
                {
                    try
                    {
                        SqlDataReader searchresult = command.ExecuteReader();

                        string res = string.Empty;
                        bool Executed = false;

                        while (searchresult.Read())
                        {
                            Executed = true;

                            MessageBox.Show($"{searchresult["name"]} {searchresult["email"]} {searchresult["phone_number"]} {searchresult["selling_rate"]} {searchresult["owner"]}");
                        }

                        if (!Executed)
                        {
                            MessageBox.Show("не найдено");
                        }
                    }
                    catch (Exception E)
                    {
                        MessageBox.Show(E.ToString());
                    }
                }
            }
        }

        private void poisktexta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
