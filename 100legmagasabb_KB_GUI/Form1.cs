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

namespace _100legmagasabb_KB_GUI
{
    public partial class Form1 : Form
    {
        MySqlConnection connection;
        public Form1()
        {
            InitializeComponent();

           
            string sqlParancs = "SELECT rank, building_name, floors FROM buildings;";

            connection = new MySqlConnection("server=localhost;userid=root;password=;database=tallest_buildings");
            connection.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter(sqlParancs, connection);
            DataSet ds = new DataSet();

            adapter.Fill(ds);

            BindingSource bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            dataGridView_adatok.DataSource = bs;

            
        }

        private void button_Orszag_Click(object sender, EventArgs e)
        {
            string adat = dataGridView_adatok.SelectedRows[0].Cells[1].Value.ToString();
            string sqlParancs = "SELECT city FROM buildings WHERE building_name = '" + adat + "';";
            MySqlCommand sqlCommand = new MySqlCommand(sqlParancs, connection);
            string varos = sqlCommand.ExecuteScalar().ToString();
            label1.Text = "Ország: " + varos;
        }

        private void button_Osszemelet_Click(object sender, EventArgs e)
        {
            string sqlParancs = "SELECT COUNT(building_name) FROM buildings WHERE height_m > 400;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlParancs, connection);
            string darab = sqlCommand.ExecuteScalar().ToString();
            label2.Text = "A 400 m-nél magasabb épületek száma: " + darab;
        }
    }
}
