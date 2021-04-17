﻿using System;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            int Count = 0;
            string query = "Select count(*) from UsersDB where Login = '" + loginBox.Text + "' and Password = '" + passwordBox.Text + "';";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                Count = Convert.ToInt32(cmDB.ExecuteScalar());
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка авторизации.");
                MessageBox.Show(ex.Message);
            }
            if(Count > 0)
            {
                Menu Win = new Menu();
                Win.Show();
                this.Hide();
            }
            if(Count == 0)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
