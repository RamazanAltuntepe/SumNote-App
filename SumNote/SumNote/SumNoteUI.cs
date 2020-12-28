using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using static SumNote.Repository;

namespace SumNote
{
    public partial class SumNoteMain : Form
    {
        public SumNoteMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void DateSelect(object sender, DateRangeEventArgs e)
        {

        }

        //child form getir
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                pnlContent.Controls.Add(childForm);
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                pnlContent.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();

            
        }

        private void btnFirstNote_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnComing_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SelectedNote());
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddNewNote());
        }

        private void SumNoteMain_Load(object sender, EventArgs e)
        {
            Repository repos = new Repository();
            repos.ConnectData();
            
                
                


        }
    }
}
