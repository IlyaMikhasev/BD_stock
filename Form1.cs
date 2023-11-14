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
using System.Xml;

namespace BD_stock
{
    public partial class Form1 : Form
    {
        static string strCon = "Server=(localdb)\\mssqllocaldb;Database=Stock;Trusted_Connection=True;";
        SqlConnection _conn = new SqlConnection(strCon);
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
            tb_connectstring.Text = strCon;
        }

        private void b_connect_Click(object sender, EventArgs e)
        {
            string sql = "select Suppliers.[name] as поставщик,Product.[name] as продукт,price as цена,dateSupply as дата,quantity as  количество" +
                " from Supplys,Product,Suppliers where Supplys.[supplier_id] = Suppliers.id and Supplys.[product_id] = Product.id ";
            SelectBD(sql);
        }
        private void SelectBD(string sqltext)
        {
            using (_conn = new SqlConnection(strCon))
            {
                _conn.Open();

                adapter = new SqlDataAdapter(sqltext, _conn);
                // Создаем объект Dataset
                ds = new DataSet();
                // Заполняем Dataset

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                adapter.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }
        private void SelectProduct(string sqltext)
        {
            using (_conn = new SqlConnection(strCon))
            {
                _conn.Open();

                adapter = new SqlDataAdapter(sqltext, _conn);
                // Создаем объект Dataset
                ds = new DataSet();
                // Заполняем Dataset

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                adapter.Fill(ds);

                dataGridView2.DataSource = ds.Tables[0];
            }
        }
        private void b_product_Click(object sender, EventArgs e)
        {
            string sql = "select Product.name as product, ProductType.name as typeProd from  Product,ProductType where ProductType.id=Product.type_id;";
            SelectBD(sql);
        }

        private void b_supplers_Click(object sender, EventArgs e)
        {
            string sql = "select * from Suppliers";
            SelectBD(sql);
        }

        private void b_type_Click(object sender, EventArgs e)
        {
            string sql = "select * from ProductType";
            SelectBD(sql);
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {

            if (rb_maxCount.Checked)
            {
                string sqltext = "select Product.name as [Товар],Supplys.quantity as [макс.количество] from Product join Supplys on" +
                    " Product.id =Supplys.product_id where Supplys.quantity=(select  MAX(quantity)  from Supplys ) ";
                SelectProduct(sqltext);
            }
            else
            if (rb_maxprice.Checked)
            {
                string sqltext = "select Product.name as [Товар],Supplys.price as [макс.цена] from Product join Supplys on" +
                    " Product.id =Supplys.product_id where Supplys.price=(select  MAX(price)as [макс.цена]  from Supplys ) ";
                SelectProduct(sqltext);
            }
            else
            if (rb_minCount.Checked)
            {
                string sqltext = "select Product.name as [Товар],Supplys.quantity as [макс.количество] from Product join Supplys on" +
                    " Product.id =Supplys.product_id where Supplys.quantity=(select  MIN(quantity)  from Supplys ) ";
                SelectProduct(sqltext);
            }
            else
            if (rb_minprice.Checked)
            {
                string sqltext = "select Product.name as [Товар],Supplys.price as [макс.цена] from Product join Supplys on" +
                   " Product.id =Supplys.product_id where Supplys.price=(select  MIN(price)as [макс.цена]  from Supplys ) ";
                SelectProduct(sqltext);
            }
        }
    }
}
/*create table ProductType(
	id int not null primary key identity(1,1),
	[name] varchar(20) not null
);
create table Product(
	id int not null primary key identity(1,1),
	[name] varchar(20) not null,
	[type_id] int not null foreign key([type_id]) references ProductType
);
create table Suppliers(
	id int not null primary key identity(1,1),
	[name] varchar(20) not null
);
create table Supplys(
	id int not null primary key identity(1,1),
	[supplier_id] int not null foreign key([supplier_id]) references Suppliers,
	[product_id] int not null foreign key([product_id]) references Product,
	price int not null ,
	dateSupply date ,
	quantity int not null
);
insert into  ProductType (name) values ('Office'),('Cloth'),('Products');
insert into  Suppliers (name) values ('microsoft'),('alliexpress'),('OZON');
insert into  Product (name,[type_id]) values ('sd-disc',1),('Shyze',2),('Aprucot',3),('keyboard',1);
insert into Supplys ([supplier_id],[product_id],price,dateSupply,quantity) values 
(2,4,155,'2023-03-02',4),
(3,5,12,'2022-02-03',12),
(1,4,89,'2023-04-04',10),
(3,5,14,'2023-06-02',22),
(2,4,13,'2022-02-09',18);*/
