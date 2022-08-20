using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Community_v1
{
    public partial class login : Form
    {
        public const string comm = "SELECT* FROM `users` WHERE `login` = @mU AND `password`= @pU";
        public login()
        {
            InitializeComponent();
        }
        //----------------------###-----------------------------//
        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            string mailUser = loginText.Text;
            string passUser = passwordText.Text;
            string path = @"..\..\..\log\lognote.txt";

            //---------------------------------------------------//

            DB database = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            //---------------------------------------------------//

            MySqlCommand command = new MySqlCommand(comm, database.getConnection());
            command.Parameters.Add("@mU", MySqlDbType.VarChar).Value = mailUser;
            command.Parameters.Add("@pU", MySqlDbType.VarChar).Value = passUser;

            //---------------------------------------------------//

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Уху... Вы вошли в систему");
                using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
                {
                    byte[] buffer = Encoding.Default.GetBytes(mailUser +" " + passUser);
                    await fstream.WriteAsync(buffer, 0, buffer.Length);
                }
               
                this.Hide();
            }
            else
                MessageBox.Show("Что-то не так...");
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegisterForm newForm = new RegisterForm();
            newForm.Show();
        }


        public int passIndex = 1;
        public string textPassForMenu = "password";

       
        private void password_see_Click(object sender, EventArgs e)
        {
            if (passIndex == 1)
            {
                passwordText.UseSystemPasswordChar = false;
                passIndex = 2;
            }
            else
            {
                passwordText.UseSystemPasswordChar = true;
                passIndex = 1;
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
