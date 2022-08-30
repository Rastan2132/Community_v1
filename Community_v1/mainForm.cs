using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Community_v1
{
    public partial class mainForm : Form
    {
        public const string comm = "SELECT* FROM `users` WHERE `nickname` = @NU";
        public mainForm()
        {
            InitializeComponent();

            string path = @"..\..\..\log\lognote.txt";
            string[] strok = File.ReadAllLines(path);

            if (strok.Length == 0)
            {
                login login = new login();
                login.Owner = this;
                login.ShowDialog();
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string nickNameUser = searchUserText.Text;

            //---------------------------------------------------//

            DB database = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            //---------------------------------------------------//

            MySqlCommand command = new MySqlCommand(comm, database.getConnection());
            command.Parameters.Add("@NU", MySqlDbType.VarChar).Value = nickNameUser;

            //---------------------------------------------------//

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                searchUser Controls = new searchUser(nickNameUser, nickNameUser);             //      !!!!!!!!
                messages.Controls.Add(Controls);
            }
            else
                MessageBox.Show("Юзер в жопе...");                                             //      !!!!!!!!
        }

        private void messages_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
