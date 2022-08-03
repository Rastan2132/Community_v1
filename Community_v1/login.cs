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

namespace Community_v1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        //----------------------###-----------------------------//
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string mailUser = loginText.Text;
            string passUser = passwordText.Text;

            //---------------------------------------------------//

            DB database = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            //---------------------------------------------------//

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @mU AND `password`= @pU", database.getConnection());
            command.Parameters.Add("@mU", MySqlDbType.VarChar).Value = mailUser;
            command.Parameters.Add("@pU", MySqlDbType.VarChar).Value = passUser;

            //---------------------------------------------------//

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                MessageBox.Show("Уху... Вы вошли в систему");
            else
                MessageBox.Show("Что-то не так...");
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
