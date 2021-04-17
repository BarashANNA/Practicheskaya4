using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pharmacists
{
    public partial class AddNewRecord : Form
    {
        public AddNewRecord()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            if (NewFIO.Text == "" || NewPhone.Text == "" || NewPost.Text == "" || NewGroup.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены");
            }
            else
            {
                string query = "INSERT INTO Pharmacists (NamePharmacists,NamePhone,id_Post,id_GroupShift) values('" + NewFIO.Text + "','" + NewPhone.Text + "','" + NewPost.Text + "','" + NewGroup.Text + "');";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                cmDB.CommandTimeout = 60;
                try
                {
                    conn.Open();
                    MySqlDataReader rd = cmDB.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Запись добавлена");
                    this.Close();
                    Menu win = new Menu();
                    win.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
