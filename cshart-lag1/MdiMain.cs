using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using System.Data.OleDb;
using  System.Net.NetworkInformation;


namespace WindowsFormsApplication1
{
    public partial class ff : Form
    {
        public ff()
        {
            InitializeComponent();
        }

        //==========================================================================
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    int k;
        //    for (k = 1; k <= 101; k += 2)
        //    { gg.Text =k.ToString();
        //      listBox1.Items.Add(k.ToString());
        //    }
        //    gg.Text = GetRectangleArea(2, 3).ToString();
        //  }  // button1

        
        //==========================================================================
        //private void button2_Click(object sender, EventArgs e)
        //{
        //   int k;
        //   for (k = 1; k <= 101; k += 2)
        //   {
        //   gg.Text = k.ToString();
        //   listBox1.Items.Add(k.ToString());
        //   };
        // Form2   ff  = new Form2();
        // ff.Age = 56;
        // gg.Text = ff.Age.ToString();
        // ff.Show();
        //}


        //==========================================================================
        private void ff_Load(object sender, EventArgs e)
        {
            bool ok = functions.CheckServer ();

        }  // button2

        //==========================================================================
        static double GetRectangleArea(double width, double height)
        {
            double area = width * height;
            return area;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GUI_ANAZ ChildForm = new GUI_ANAZ();
            ChildForm.MdiParent = this;
            ChildForm.Text = "Ρύθμιση Εκτύπωσης ";                            // + m_ChildFormNumber;
            ChildForm.f_TableName = "PEL";
            ChildForm.f_MENUID = 1;
            ChildForm.Show();
        
        }

        private void button5_Click(object sender, EventArgs e)
        {


            QUERY_SETUP ChildForm = new QUERY_SETUP();
            //System.Windows.Forms.Form
            ChildForm.MdiParent = this;
           // m_ChildFormNumber += 1;
            ChildForm.Text = "Ρύθμιση Εκτύπωσης ";                            // + m_ChildFormNumber;
            //if (m_ChildFormNumber % 2 == 1)
            //{
            //    ChildForm.BackColor = Color.Beige;
            //}
            //else
            //{
            //    ChildForm.BackColor = Color.Blue;
            //}
            ChildForm.f_TableName = "PEL";
            ChildForm.f_MENUID = 1;
            ChildForm.Show();
        }

        private void APOT_SETUP_Click(object sender, EventArgs e)
        {
            QUERY_SETUP ChildForm = new QUERY_SETUP();
            ChildForm.MdiParent = this;
            ChildForm.Text = "Ρύθμιση Εκτύπωσης ";                            // + m_ChildFormNumber;
            ChildForm.f_TableName = "EID";
            ChildForm.f_MENUID = 2;
            ChildForm.Show();


        }

        private void apot_Click(object sender, EventArgs e)
        {
            GUI_ANAZ Child2Form = new GUI_ANAZ();
            Child2Form.MdiParent = this;
            Child2Form.Text = "Ευρετήριο Ειδών ";                            // + m_ChildFormNumber;
            Child2Form.f_TableName = "EID";
            Child2Form.f_MENUID = 2;
            Child2Form.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            Form2 Child2Form = new Form2();
            Child2Form.MdiParent = this;
            Child2Form.Text = "Ευρετήριο Ειδών ";                            // + m_ChildFormNumber;
            
            Child2Form.Show();

            
            
            
            

        }

        private void Button4_Click(object sender, EventArgs e)
        {

            editing Child2Form = new editing();
            Child2Form.MdiParent = this;
            Child2Form.Text = "Ενημέρωση ";                            // + m_ChildFormNumber;

            Child2Form.Show();



        }

        private void button1_Click(object sender, EventArgs e)
        {

            Utilities ChildForm = new Utilities();
            ChildForm.MdiParent = this;
            ChildForm.Text = "Ρύθμιση Εκτύπωσης ";                            // + m_ChildFormNumber;
          //  ChildForm.f_TableName = "EID";
          //  ChildForm.f_MENUID = 1;
            ChildForm.Show();
        }





    }  //class
 }
    

