
using System.Data.OleDb;



namespace SumNote
{

    public class Repository
    {
        


        OleDbConnection con = new OleDbConnection
        (@"Provider=Microsoft.ACE.OLEDB.12.0;
        Data Source=C:\Users\Dell\Desktop\c#\SumNote-App\SumNote\SumNote\Properties\repos\Entries.xlsx;
        Extended Properties='Excel 12.0 Xml; HDR = YES;'"
        );

        public void AddNote()
        {
        //    if (con != null)
        //    {
        //        con.Open();
        //        OleDbCommand command = new OleDbCommand(
        //            "insert into [Note$] (NoteHeader,NoteText,SaveDate) values (@p1,@p2,@p3)", con);
        //        command.Parameters.AddWithValue("@p1", note.Header );
        //        command.Parameters.AddWithValue("@p2", note.Text);
        //        command.Parameters.AddWithValue("@p3", note.Date);
        //        int entry = command.ExecuteNonQuery();
        //        con.Close();
        //        if (entry > 0)
        //        {
        //            MessageBox.Show("sonunda başardın");
        //        }
        //        else
        //        {
        //            MessageBox.Show("başaramadık abi");
        //        }



        //    }
        //    else
        //    {
        //        con.Open();
        
    }



    }

}
