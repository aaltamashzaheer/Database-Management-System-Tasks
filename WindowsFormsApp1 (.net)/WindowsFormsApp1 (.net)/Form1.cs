using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;




namespace WindowsFormsApp1__.net_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Form1_Load() called...");
            process_log.Text = "Startup...";
            try
            {
                System.Diagnostics.Debug.WriteLine("within the try");
                SqlConnection connection = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
                connection.Open();
                process_log.Text = "Connection Successful";
                connection.Close();
            }
            catch (Exception ex)
            {
                process_log.Text = "Error, " + ex;
            }
        }
        private void view_database_button_Click(object sender, EventArgs e)
        {
            string currentTable = ""; 
            if (radioButton3.Checked)
            {
                currentTable = "Customers";
            }
            else if (radioButton2.Checked)
            {
                currentTable = "Employees";
            }
            else if (radioButton1.Checked)
            {
                currentTable = "Orders";
            }

            database_view.DataSource = null;
            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection connection = new SqlConnection(@"Data Source = (local)\SQLEXPRESS; Initial Catalog = Northwind; Integrated Security = True");
                var datasource = @"(local)\SQLEXPRESS";
                var database = "Northwind";
                var thisUsername = Loginform.username;
                var thisPassword = Loginform.password;
                string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + "; Persist Security Info=True;User ID=" + thisUsername + ";Password=" + thisPassword;
                SqlConnection conn = new SqlConnection(connString); conn.Open();
                process_log.Text = "Retrieving Records..."; command.Connection = conn;
                command.CommandText = "select * from " + currentTable;
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable(); da.Fill(dt);

                database_view.DataSource = dt;
                process_log.Text = "Retrieval Successful!"; conn.Close();
            }
            catch (Exception ex)
            {
                process_log.Text = "Error, " + ex;
            }
        }

        private void update_database_button_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
            connection.Open();
            process_log.Text = "Inserting Record...";
            command.Connection = connection;
            command.CommandText = "insert into Customers (CustomerID, CompanyName) values('" + id_input.Text + "','" + contact_name_input.Text + "')";
            command.ExecuteNonQuery();
            process_log.Text = "Record Inserted...";
            connection.Close();
            view_database_button_Click(sender, e);
        }

        private void count_records_button_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
            connection.Open();
            process_log.Text = "Counting Records...";
            command.Connection = connection;
            command.CommandText = "select count(*) from Customers";
            int count = (int)command.ExecuteScalar();
            process_log.Text = "Number of records: " + count;
            connection.Close();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
            connection.Open();
            process_log.Text = "Deleting Record...";
            command.Connection = connection;
            command.CommandText = "delete from Customers where CustomerID = '"+id_input.Text+"'";
            command.ExecuteNonQuery();
            process_log.Text = "Record Deleted...";
            connection.Close();
            view_database_button_Click(sender, e);
        }


    }
}