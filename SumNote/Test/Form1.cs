using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection
            (@"Provider=Microsoft.ACE.OLEDB.12.0;
                Data Source=C:\Users\Dell\Desktop\c#\SumNote-App\SumNote\SumNote\Properties\repos\Entries.xlsx;
                Extended Properties='Excel 12.0 Xml; HDR = YES;'"
            );
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select * From [Note$]", con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            Test.DataSource = dataTable;
        }
    }
}
