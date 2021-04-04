using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employees
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {   dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("FNAME", typeof(string));
            dt.Columns.Add("LNAME", typeof(string));
            dt.Columns.Add("DOB", typeof(string));
            dt.Columns.Add("Adress", typeof(string));
            dt.Columns.Add("Department", typeof(string)); }

        private void button1_Click(object sender, EventArgs e)
        {
        dt.Rows.Add(Convert.ToInt32(TXT_ID.Text), TXT_FNAME.Text, TXT_LNAME.Text, TXT_BOD.Text, TXT_ADRESS.Text, CMB_SECTION.Text);
       DGV.DataSource = dt;
            cln();
         }

        void cln()
        
           { TXT_ID.Clear();
            TXT_FNAME.Clear();
            TXT_LNAME.Clear();
            TXT_ADRESS.Clear();
            CMB_SECTION.Text = "";}
            
        private void DGV_Click(object sender, EventArgs e)
        { int i = DGV.CurrentRow.Index;
            TXT_ID.Text = dt.Rows[i][0].ToString();
            TXT_FNAME.Text = DGV.Rows[i].Cells[1].Value.ToString();
            TXT_LNAME.Text = dt.Rows[i][2].ToString();
            TXT_ADRESS.Text = dt.Rows[i][4].ToString();
            TXT_BOD.Text = dt.Rows[i][3].ToString();
            CMB_SECTION.Text = dt.Rows[i][5].ToString();  }
     
        private void button2_Click(object sender, EventArgs e)
        {
            int i = DGV.CurrentRow.Index;
            dt.Rows.RemoveAt(i);
            //DGV.DataSource = dt;
            cln();     }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = DGV.CurrentRow.Index;
             dt.Rows[i][0]= TXT_ID.Text ;
            DGV.Rows[i].Cells[1].Value= TXT_FNAME.Text ;
           dt.Rows[i][2] = TXT_LNAME.Text ;
             dt.Rows[i][4]= TXT_ADRESS.Text;
           dt.Rows[i][3] = TXT_BOD.Text ;
            dt.Rows[i][5]= CMB_SECTION.Text ;  }
      

        private void button4_Click(object sender, EventArgs e)
        {
           DataTable dt1 = new DataTable();
            dt1.Columns.Add("ID", typeof(int));
            dt1.Columns.Add("FNAME", typeof(string));
            dt1.Columns.Add("LNAME", typeof(string));
            dt1.Columns.Add("DOB", typeof(string));
            dt1.Columns.Add("Adress", typeof(string));
            dt1.Columns.Add("Department", typeof(string));
           
            for (int i=0;i<dt.Rows.Count;i++)
            {
                if(dt.Rows[i][0].ToString()== textBox1.Text)
                {
                  TXT_ID.Text = dt.Rows[i][0].ToString();
                    TXT_FNAME.Text = DGV.Rows[i].Cells[1].Value.ToString();
                    TXT_LNAME.Text = dt.Rows[i][2].ToString();
                    TXT_ADRESS.Text = dt.Rows[i][4].ToString();
                    TXT_BOD.Text = dt.Rows[i][3].ToString();
                    CMB_SECTION.Text = dt.Rows[i][5].ToString();

                    dt1.Rows.Add(dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3], dt.Rows[i][4], dt.Rows[i][5]);
                    DGV.DataSource = dt1;
                 }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            DGV.DataSource = dt;
        }
        private void TXT_ID_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
