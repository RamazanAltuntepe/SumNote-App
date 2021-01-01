using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Test
{
    static class Program
    {
        




       
        static void Main()
        { 
            List<Note> notes = new List<Note>();

            SaveToExcel(notes);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static void SaveToExcel(IEnumerable<Note> note)
        {
            var excelApp = new Excel.Application();
            excelApp.Visible = true;
            excelApp.Workbooks.Add();
            Excel._Worksheet workSheet = excelApp.ActiveSheet;
            workSheet.Cells[1, "A"] = "Note Header";
            workSheet.Cells[1, "B"] = "Note Content";

            int row = 1;
            foreach (var not in note)
            {
                row++;
                workSheet.Cells[row, "A"] = not.Header;
                workSheet.Cells[row, "B"] = not.Text;
            }

        }

    }

    public class Note
    {

        public string Header { get; set; }
        public string Text { get; set; }
    }
}
