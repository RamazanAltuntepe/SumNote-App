using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumNote
{
    public class Repository
    {
        public void ConnectData()
        {
            try
            {
                OleDbConnection con = new OleDbConnection
                (@"Provider=Microsoft.ACE.OLEDB.12.0;
                Data Source=C:\Users\Dell\Desktop\c#\SumNote-App\SumNote\SumNote\Properties\repos\Entries.xlsx;
                Extended Properties='Excel 12.0 Xml; HDR = YES;'"
                );
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        public void GetData()
        {
            OleDbConnection con = new OleDbConnection
            (@"Provider=Microsoft.ACE.OLEDB.12.0;
                Data Source=C:\Users\Dell\Desktop\c#\SumNote-App\SumNote\SumNote\Properties\repos\Entries.xlsx;
                Extended Properties='Excel 12.0 Xml; HDR = YES;'"
            );
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select * From [Notes$]",con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            element.DataSource = dataTable;

        }
        
    }
}
