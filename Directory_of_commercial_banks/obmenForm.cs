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
    public partial class obmenForm : Form
    {
        List<string> data = new List<string>();
        int neededindex;

        public obmenForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            neededindex = comboBox1.SelectedIndex;
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source = DESKTOP - BTPASGH; Initial Catalog = directory_of_commercial_banks; Integrated Security = True";
                connection.Open();


                using (SqlCommand command = new SqlCommand($"SELECT name FROM Bank;", connection))
                {
                    string mas = "...";
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        try
                        {
                            string result = reader.GetString(0);
                            comboBox1.Items.Add(result);
                            comboBox1.Text = result;
                            data.Add(result);
                        }
                        catch (Exception Mass)
                        {
                            MessageBox.Show(mas);
                        }
                    }
                }
            }
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source = DESKTOP - BTPASGH; Initial Catalog = directory_of_commercial_banks; Integrated Security = True";
                connection.Open();

                using (SqlCommand command = new SqlCommand($"SELECT * FROM Department WHERE bank_name = '{data[neededindex]}';", connection))
                {
                    string mas = "...";
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        try
                        {
                            string result = reader.GetString(0);
                            comboBox2.Items.Add(result);
                            comboBox2.Text = result;
                            MessageBox.Show(result);


                        }
                        catch (Exception Mass)
                        {
                            MessageBox.Show(mas);
                        }
                    }
                }
            }
        }
    }
}








