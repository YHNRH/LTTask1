using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LTTask1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds;
            SqlDataAdapter adapter;
            string connectionString = @ConfigurationManager.ConnectionStrings["connectionString"].ToString();
            string sql = "select l.DATELOAD as N'Дата загрузки', l.DATETIMEFIXED as N'Дата значения факта на 2 часа ночи', p.NAME as N'Наименование', s.VRECEIPT as N'Значение поступления', N'Тонны' as N'Ед. изм.'  from LPRODUCT as p " +
                " join FACTSOURCE as s on p.KSSSPROD = s.KSSSPROD" +
                " join FACTLOAD as l on s.IDFACTLOAD = l.IDFACTLOAD" +
                " where DATETIMEFIXED > '2014-12-24' and s.KSSSUNIT = 122 and p.IDPRODUCTGROUP = 5" +
                " order by l.DATETIMEFIXED desc, p.name";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
