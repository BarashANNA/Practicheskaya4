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
    public partial class AddNewUser : Form
    {
        public AddNewUser()
        {
            InitializeComponent();
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            if (NewLogin.Text == "" || NewPassword.Text == "")
            {
                MessageBox.Show("Поля должны быть заполнены");
            }
            else
            {
                string query = "INSERT INTO UsersDB(Login,Password) values('" + NewLogin.Text + "','" + NewPassword.Text + "');";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                cmDB.CommandTimeout = 60;
                try
                {
                    conn.Open();
                    MySqlDataReader rd = cmDB.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Новый пользователь добавлен.");
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
