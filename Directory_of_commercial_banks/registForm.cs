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
    public partial class registForm : Form
    {
        public registForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loginUser1 = loginField1.Text;
            string passUser1 = passField2.Text;
            string identcode = codField.Text;
            string name = nameField.Text;
            string lastname = lastField.Text;
            string date1 = dateField1.Text;
            string date2 = dateField2.Text;
            string date3 = dateField3.Text;

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source = DESKTOP-BTPASGH; Initial Catalog = directory_of_commercial_banks; Integrated Security = True";
                connection.Open();

                using (SqlCommand command = new SqlCommand($"INSERT INTO [User] VALUES ({identcode},'{loginUser1}','{passUser1}','{name}','{lastname}',CAST ('{date3.ToString()}-{date2.ToString()}-{date1.ToString()}' as datetime));", connection))
                {
                    string mas = $"INSERT INTO [User] VALUES ({identcode},'{loginUser1}','{passUser1}','{name}','{lastname}',CAST ('{date3.ToString()}-{date2.ToString()}-{date1.ToString()}' as datetime));";

                    try
                    {
                        command.ExecuteScalar();
                        MessageBox.Show(mas);

                    }
                    catch (Exception Mass)
                    {
                        MessageBox.Show(Mass.ToString());
                    }
                }
            }
        }
    }
}

