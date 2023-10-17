using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace kafedra_uchebnaya
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-Q2FHEGB; Initial Catalog = 21.101-05-Ucheba studentov; Integrated Security = True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
        }
        void BindData()
        {
            string cmd = "select * from Disciplinu";
            SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable("Disciplinu");
            adapter.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            var id = textBox1.Text;
            int Id = int.Parse(id);
            string query = $"select * from Disciplinu where Kod_disciplinu = '{Id}'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;
            textBox1.Text = "";
            sqlConnection.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var id = kod_disciplinu.Text;
            int Id = int.Parse(id);
            var id_kafedra = kod_kafedru.Text;
            int Id_kafedra = int.Parse(id_kafedra);
            var name = name_dis.Text;
            var time = raschasovka.Text;
            int Timing = int.Parse(time);
            var kontrol = Kontrol.Text;
            sqlConnection.Open();
            string query = $"insert into Disciplinu(Kod_disciplinu, Kod_kafedru , Name_dis, Raschasovka, Kontrol) values ('{Id}','{Id_kafedra}','{name}','{Timing}','{kontrol}')";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            BindData();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var id = kod_disciplinu.Text;
            int Id = int.Parse(id);

            sqlConnection.Open();
            string query = $"delete Disciplinu where Kod_disciplinu='{Id}'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            BindData();
        }

        private void kontrol_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
