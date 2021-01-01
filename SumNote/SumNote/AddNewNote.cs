using System;
using System.Data.OleDb;
using System.Windows.Forms;


namespace SumNote
{
    public partial class AddNewNote : Form
    {
        OleDbConnection con = new OleDbConnection
        (@"Provider=Microsoft.ACE.OLEDB.12.0;
        Data Source=C:\Users\Dell\Desktop\c#\SumNote-App\SumNote\SumNote\Properties\repos\Entries.xlsx;
        Extended Properties='Excel 12.0 Xml; HDR = YES;'"
        );

        //Note note = new Note();
        
        

        //Repository repo = new Repository();
        public AddNewNote()
        {
            InitializeComponent();
        }

        private void AddNewNote_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbxHeader_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           


        }

        private void btnAdd_MouseClick(object sender, MouseEventArgs e)
        {

            //new Note() { Header = tbxHeader.Text, Text = tbxText.Text, Date = dateTimePicker.ToString() };
            //repo.AddNote();

            string header = tbxHeader.Text;
            string textContent = tbxText.Text;
            var dateTime = dateTimePicker.Text.ToString();
            if (con != null)
            {
                con.Open();
                OleDbCommand command = new OleDbCommand(
                    "insert into [Note$] (NoteHeader,NoteText,SaveDate) values (@p1,@p2,@p3)", con);
                command.Parameters.AddWithValue("@p1", header);
                command.Parameters.AddWithValue("@p2", textContent);
                command.Parameters.AddWithValue("@p3",dateTime);
                int entry = command.ExecuteNonQuery();
                con.Close();
                if (entry > 0)
                {
                    MessageBox.Show("sonunda başardın");
                }
                else
                {
                    MessageBox.Show("başaramadık abi");
                }



            }
            else
            {
                con.Open();

            }
    }
}
