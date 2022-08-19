﻿using MySql.Data.MySqlClient;
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
        public const string comm = "INSERT INTO `users` (`login`, `password`, `nickname`) VALUES(@login, @password, @nickname);";

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
            if (passText.Text != passText2.Text|| passText.Text == "" || passText2.Text == "" || loginText.Text=="")
                MessageBox.Show("Что-то не так... Проверь пароль");
            else {
                /////////////////////////////////////////////////////////////////,, `data_of_birth` , @data_of_birth

                MySqlCommand command = new MySqlCommand(comm, database.getConnection());
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginText.Text;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passText.Text;
                command.Parameters.Add("@nickname", MySqlDbType.VarChar).Value = loginText.Text;
               // command.Parameters.Add("@data_of_birth", MySqlDbType.VarChar).Value = dateTime.Value;

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
    }
}
