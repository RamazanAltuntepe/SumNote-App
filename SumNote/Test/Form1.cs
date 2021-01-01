using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace Test
{
    public partial class Form1 : Form
    {
        
        //Excel connection string
        OleDbConnection con = new OleDbConnection
        (@"Provider=Microsoft.ACE.OLEDB.12.0;
                Data Source=C:\Users\Dell\Desktop\c#\SumNote-App\SumNote\SumNote\Properties\repos\Entries.xlsx;
                Extended Properties='Excel 12.0 Xml; HDR = YES;'"
        public Form1()
        {
            con.Open();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            );
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select * From [Note$]", con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            Test.DataSource = dataTable;
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            Note note = new Note();
            note.Header = textBox1.Text;
            note.Text = textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
