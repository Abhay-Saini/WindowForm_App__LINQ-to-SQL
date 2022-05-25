using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowForm_App
{
    public partial class Form1 : Form
    {
        StudentDBDataContext db;
        List<Student> std_tbl;
        int Index_no = 0;
       

        public Form1()
        {
            InitializeComponent();
        }

        public object DataGridView1 { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            //StudentDBDataContext db = new StudentDBDataContext();
            //dataGridView1.DataSource = db.Students;
            //Table<Student> std_tbl = db.Students;
            //dataGridView1.DataSource = std_tbl;
            db = new StudentDBDataContext();
            std_tbl = db.Students.ToList();
            DisplayData();
        }

        private void DisplayData()
        {
            IDTextBox.Text = std_tbl[Index_no].Id.ToString();
            NameTextBox.Text = std_tbl[Index_no].Name;
            GenderTextBox.Text = std_tbl[Index_no].Gender;
            AgeTextBox.Text = std_tbl[Index_no].Age.ToString();
            StandardTextBox.Text = std_tbl[Index_no].Stundard.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            if (Index_no < std_tbl.Count() - 1)
            {
                Index_no += 1;
                DisplayData();
            }
        }

        private void Previousbutton_Click(object sender, EventArgs e)
        {
            if (Index_no >  0)
            {
                Index_no -= 1;
                DisplayData();
            }
        }
    }
}
