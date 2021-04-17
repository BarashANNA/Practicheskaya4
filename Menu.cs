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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

        }
        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string query = "select Pharmacists.Id_Pharmacists, GroupShift.NameGroup, Pharmacists.NamePharmacists, Post.NamePost from Pharmacists join Post on Pharmacists.id_Post = Post.Id_Post join GroupShift on Pharmacists.id_GroupShift = GroupShift.Id_GroupShift ORDER BY Id_Pharmacists ASC;";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3)};
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);
                    }
                }
                conn.Close();
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к БД");
                MessageBox.Show(ex.Message);
            }
        }

        private void AddNewUser_Click(object sender, EventArgs e)
        {
            AddNewUser win = new AddNewUser();
            win.Show();
            this.Hide();
        }

        private void AddNewRecord_Click(object sender, EventArgs e)
        {
            AddNewRecord Swin = new AddNewRecord();
            Swin.Show();
            this.Hide();
        }
    }
}

