using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Community_v1
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        public const string comm = "INSERT INTO `users` (`login`, `password`, `nickname`, `data_of_birth`) VALUES(@login, @password, @nickname, @data_of_birth);";
        public const string commChek = "SELECT* FROM `users` WHERE `login` = @login";
        public int passIndex = 1;


        private void password_see_Click(object sender, EventArgs e)
        {
            if (passIndex == 1)
            {
                passText.UseSystemPasswordChar = false;
                passText2.UseSystemPasswordChar = false;
                passIndex = 2;
            }
            else
            {
                passText.UseSystemPasswordChar = true;
                passText2.UseSystemPasswordChar = true;
                passIndex = 1;
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            passText.UseSystemPasswordChar = true;
            passText2.UseSystemPasswordChar = true;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {

            DB database = new DB();
             
            /////////////////////////////////////////////////////////////////

            if (ChekUser())
                return; ;

            if (passText.Text != passText2.Text|| passText.Text == "" || passText2.Text == "" || loginText.Text=="")
                MessageBox.Show("Что-то не так... Проверь пароль");
            else {

                /////////////////////////////////////////////////////////////////,

                MySqlCommand command = new MySqlCommand(comm, database.getConnection());
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginText.Text;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passText.Text;
                command.Parameters.Add("@nickname", MySqlDbType.VarChar).Value = loginText.Text;
                command.Parameters.Add("@data_of_birth", MySqlDbType.VarChar).Value = dateTime.Value.ToString("yyyy-MM-dd");

                /////////////////////////////////////////////////////////////////

                database.openConnection();
                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Все хорошо");
                else
                    MessageBox.Show("повторите через 5 минут...");
                database.clouseConnection();
                this.Close();
                }
        }
        public bool ChekUser()
        {
            DB database = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            /////////////////////////////////////////////////////////////////

            MySqlCommand command = new MySqlCommand(commChek, database.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginText.Text;

            /////////////////////////////////////////////////////////////////

            adapter.SelectCommand = command;
            adapter.Fill(table);
            database.openConnection();
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Этот e-mail занят");
                return true;
            }
            else
                return false;
        }

        private void cueTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
