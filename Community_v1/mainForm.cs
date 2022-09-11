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
    public partial class
        mainForm : Form
    {
        public string labelName
        {
            get {return NameOfYourFrend.Text; }
            set { NameOfYourFrend.Text = value; }
        }
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
                searchUser Controls = new searchUser(nickNameUser, nickNameUser, 1, 1, this);             //      !!!!!!!!
                Controls.Click += this.searchUser_Click;
                messages.Controls.Add(Controls);
            }
            else
                MessageBox.Show("Юзер в жопе...");                                             //      !!!!!!!!
        }
        private void searchUser_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
         //   NameOfYourFrend.text = name;
        }
        private void messages_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NameOfYourFrend_Click(object sender, EventArgs e)
        {

        }

        private void mainForm_ResizeEnd(object sender, EventArgs e)
        {
            int x = this.Width;
            this.panelMess.Width = x - 400;
        }

        private void top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textMess_TextChanged(object sender, EventArgs e)
        {

        }

        private void cueTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string path = @"..\..\..\log\lognote.txt";

            //---------------------------------------------------//
           
               
            
                File.Delete(path);
                

                this.Close();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime();

            yourMess Controls = new yourMess(cueTextBox1.Text, date1);             //      !!!!!!!!
            cueTextBox1.Text = "";
            flowLayoutPanel1.Controls.Add(Controls);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
        }
    }
}
