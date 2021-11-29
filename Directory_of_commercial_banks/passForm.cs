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
    public partial class passForm : Form
    {
        public passForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            string passUser = passField.Text;


            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=DESKTOP-BTPASGH;Initial Catalog=directory_of_commercial_banks;Integrated Security=True";
                connection.Open();

                using (SqlCommand command = new SqlCommand($"SELECT password FROM [User] WHERE login = '{loginUser}'", connection))
                {
                    string passuser = "";
                    try
                    {
                        passuser = command.ExecuteScalar().ToString();
                    }
                    catch (NullReferenceException)
                    {

                    }


                    if (passuser == "" & loginUser != "Danil")
                    {
                        MessageBox.Show("Неправильный логин");
                    }

                    if (passuser == passUser)
                    {

                    }

                    if (passuser != passUser & passUser != "12345")
                    {
                        MessageBox.Show("Неправильный пароль");
                    }

                    //if (passuser == passUser)
                    //{
                    //    this.Hide();
                    //    Search poisk = new Search();
                    //    poisk.Show();
                    //}
                }

                //while (loginUser == "Danil" && passUser == "12345")
                //{
                //    this.Hide();
                //    passForm admin = new passForm();
                //    admin.Show();

                //    if (loginUser == "Danil" && passUser == "12345")
                //        break;
                //}
            }
        }

        private void adminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "directory_of_commercial_banksDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.directory_of_commercial_banksDataSet.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "directory_of_commercial_banksDataSet.Bank". При необходимости она может быть перемещена или удалена.
            this.bankTableAdapter.Fill(this.directory_of_commercial_banksDataSet.Bank);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            registForm registerForm = new registForm();
            registerForm.Show();
        }
    }
}

        