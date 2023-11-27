using DataConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BD_stock
{
    public partial class Form1 : Form
    {
        static string strCon = $"Data Source ={Environment.MachineName}\\SQLEXPRESS; database = Stock; Integrated Security = SSPI; Connect Timeout = 10;TrustServerCertificate=True";
        SqlConnection _conn = new SqlConnection(strCon);
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds;
        MSSQL ms_conn = new MSSQL(strCon);
        public Form1()
        {
            InitializeComponent();
            tb_connectstring.Text = strCon;
            GetType();
            GetSyppliers();
            ms_conn.GetConnection();
        }
        private void createDB()
        {
            SqlConnection myConn = new SqlConnection($"Data Source={Environment.MachineName}\\SQLEXPRESS;Integrated security=SSPI;database=master");

            string str = "CREATE DATABASE  Stock";

            SqlCommand myCommand = new SqlCommand(str, myConn);
            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();

            }
            /*catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
            myConn = new SqlConnection($"Data Source ={Environment.MachineName}\\SQLEXPRESS; database = Stock; Integrated Security = SSPI; Connect Timeout = 10;");
            str = "create table ProductType("+
                    " id int not null primary key identity(1, 1)," +
                    " [name] varchar(20) not null);" +
                  "create table Product(" +
                    "id int not null primary key identity(1, 1), " +
                    "[name] varchar(20) not null,"+
                    "[type_id] int not null foreign key([type_id]) references ProductType );" +           
                  "create table Suppliers(" +
                    "id int not null primary key identity(1, 1), " +
                    "[name] varchar(20) not null);"+
                  "create table Supplys(" +
                    "id int not null primary key identity(1, 1), " +
                    "[supplier_id] int not null foreign key([supplier_id]) references Suppliers, " +
                    "[product_id] int not null foreign key([product_id]) references Product, " +
                    "price int not null, " +
                    "dateSupply date, " +
                    "quantity int not null );";
            string insert = "insert into  ProductType (name) values ('Office'),('Cloth'),('Products');" +
                "insert into  Suppliers (name) values ('microsoft'),('alliexpress'),('OZON');" +
                "insert into  Product (name,[type_id]) values ('sd-disc',1),('Shyze',2),('Aprucot',3),('keyboard',1);" +
                "insert into Supplys ([supplier_id],[product_id],price,dateSupply,quantity) values " +
                "(2,2,155,'2023-03-02',4),(3,3,12,'2022-02-03',12),(1,1,89,'2023-04-04',10),(3,2,14,'2023-06-02',22),(2,1,13,'2022-02-09',18);";
            myCommand = new SqlCommand(str+insert, myConn);
            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (System.Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }
        private void b_connect_Click(object sender, EventArgs e)
        {
             string sql = "select Suppliers.[name] as поставщик,Product.[name] as продукт,price as цена,dateSupply as дата,quantity as  количество" +
                " from Supplys,Product,Suppliers where Supplys.[supplier_id] = Suppliers.id and Supplys.[product_id] = Product.id ";

            SelectBD_myClassBD(sql,dataGridView1);
            
        }
        private void SelectBD(string sqltext,DataGridView grid)
        {
            using (_conn = new SqlConnection(strCon))
            {
                _conn.Open();

                adapter = new SqlDataAdapter(sqltext, _conn);
                ds = new DataSet();

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                adapter.Fill(ds);

                grid.DataSource = ds.Tables[0];
            }
        }
        private void SelectBD_myClassBD(string sqltext, DataGridView grid)
        {
            ms_conn.ConnectOpen();
            ds = new DataSet();
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(ms_conn.GetAdapter(sqltext) as SqlDataAdapter);
            ms_conn.DataAdapter.Fill(ds);
            grid.DataSource = ds.Tables[0];
            ms_conn.ConnectClose();
        }

        private void b_product_Click(object sender, EventArgs e)
        {
            string sql = "select Product.[name] as product, ProductType.[name] as typeProd from  Product,ProductType where ProductType.id=Product.type_id;";
            SelectBD(sql, dataGridView1);
        }

        private void b_supplers_Click(object sender, EventArgs e)
        {
            string sql = "select * from Suppliers";
            SelectBD(sql, dataGridView1);
        }

        private void b_type_Click(object sender, EventArgs e)
        {
            string sql = "select * from ProductType";
            SelectBD(sql, dataGridView1);
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {

            if (rb_maxCount.Checked)
            {
                string sqltext = "select Product.name as [Товар],Supplys.quantity as [макс.количество] from Product join Supplys on" +
                    " Product.id =Supplys.product_id where Supplys.quantity=(select  MAX(quantity)  from Supplys ) ";
                SelectBD(sqltext, dataGridView2);
            }
            else
            if (rb_maxprice.Checked)
            {
                string sqltext = "select Product.name as [Товар],Supplys.price as [макс.цена] from Product join Supplys on" +
                    " Product.id =Supplys.product_id where Supplys.price=(select  MAX(price)as [макс.цена]  from Supplys ) ";
                SelectBD(sqltext, dataGridView2);
            }
            else
            if (rb_minCount.Checked)
            {
                string sqltext = "select Product.name as [Товар],Supplys.quantity as [мин.количество] from Product join Supplys on" +
                    " Product.id =Supplys.product_id where Supplys.quantity=(select  MIN(quantity)  from Supplys ) ";
                SelectBD(sqltext, dataGridView2);
            }
            else
            if (rb_minprice.Checked)
            {
                string sqltext = "select Product.name as [Товар],Supplys.price as [мин.цена] from Product join Supplys on" +
                   " Product.id =Supplys.product_id where Supplys.price=(select  MIN(price)as [макс.цена]  from Supplys ) ";
                SelectBD(sqltext, dataGridView2);
            }
        }

        private void b_createDB_Click(object sender, EventArgs e)
        {
            createDB();
            b_createDB.Enabled = false;
            b_connect.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (_conn = new SqlConnection(tb_connectstring.Text))
            {
                _conn.Open();
            }
        }

        private void b_oldProduct_Click(object sender, EventArgs e)
        {
            string sql = "select TOP(1) Supplys.dateSupply as [дата],Product.[name] as product from Product join Supplys on Product.id =Supplys.product_id order by Supplys.dateSupply";
            SelectBD(sql, dataGridView3);
        }

        private void b_avg_Click(object sender, EventArgs e)
        {

            string sql = "select AVG(Supplys.quantity) as [количество], ProductType.[name] as typeProd from  Product,ProductType,Supplys " +
               " where Supplys.[product_id] = Product.id and ProductType.id=Product.type_id group by  ProductType.[name] ";

            SelectBD(sql, dataGridView3);
        }

        private void cb_types_SelectedValueChanged(object sender, EventArgs e)
        {
            string sql = "select ProductType.[name] as [тип продукта], Suppliers.[name] as поставщик,Product.[name] as продукт,price as цена,dateSupply as дата,quantity as  количество" +
                " from Supplys,Product,Suppliers,ProductType where Supplys.[supplier_id] = Suppliers.id and Supplys.[product_id] = Product.id and ProductType.id = Product.type_id and " +
                $"ProductType.[name]='{cb_types.SelectedItem}'";
            SelectBD(sql, dataGridView3);
        }
        private void GetType()
        {
            string sql = "select ProductType.[name] from ProductType";
            using (_conn = new SqlConnection(strCon))
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cb_types.Items.Add(reader.GetString(0));
                    }
                }
                _conn.Close();
            }
        }
        private void GetSyppliers()
        {
            string sql = "select Suppliers.[name] from Suppliers";
            using (_conn = new SqlConnection(strCon))
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cb_supplyes.Items.Add(reader.GetString(0));
                    }
                }
                _conn.Close();
            }
        }

        private void cb_supplyes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select Suppliers.[name] as поставщик,Product.[name] as продукт,price as цена,dateSupply as дата,quantity as  количество" +
                " from Supplys,Product,Suppliers where Supplys.[supplier_id] = Suppliers.id and Supplys.[product_id] = Product.id and " +
                $"Suppliers.[name]='{cb_supplyes.SelectedItem}'";
            SelectBD(sql, dataGridView3);
        }
    }
}
