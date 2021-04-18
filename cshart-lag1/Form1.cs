using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FocusedTextBox;
using FocusedCombo;



namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int f_menuid; // Field declaration
        
        //============ properties =================================
        
        public int f_MENUID // Property declaration
        {
            get { return this.f_menuid; }
            set { this.f_menuid = value; } // Setter declaration
        }

        private string f_tablename; // Field declaration
        public string f_TableName // Property declaration
        {
            get { return this.f_tablename; }
            set { this.f_tablename = value; } // Setter declaration
        }


        private int f_id; // Field declaration
        public int f_ID // Property declaration
        {
            get { return this.f_id; }
            set { this.f_id = value; } // Setter declaration
        }


        private string f_menuname; // Field declaration
        public string f_MENUNAME // Property declaration
        {
            get { return this.f_menuname; }
            set { this.f_menuname = value; } // Setter declaration
        }


        string[] fValues = new string[50];
        string[] fFieldNames = new string[50];
        int nfFieldNames = 0;


        FocusedTextBox.FocusedTextBox[] t1 = new FocusedTextBox.FocusedTextBox[50];
        FocusedCombo.FocusedCombo[] tCombo = new FocusedCombo.FocusedCombo[50];



        private void Form1_Load(object sender, EventArgs e)
     //private void form1_load(object sender, EventArgs e)
        {
        // σχεδίαση φόρμας εισαγωγής/διόρθωσης εγγραφής  
  

            DataTable dt=functions.ExecuteSQLQuery("select * from "+f_TableName+"  WHERE  ID="+f_ID.ToString ());
            if (dt.Rows.Count == 0)
                return;

            TableLayoutPanel Table = new TableLayoutPanel();
            Table.Location = new Point(10, 40);
            Table.Size = new Size(620, 100);
            Table.AutoSize = true;
            // You should write the code to set Anchor property programmatically only in the Form_Load event
            Table.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            Table.Name = "Desk";
            Table.ColumnCount = 6;
            Table.RowCount = 0;
            Table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Table.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddRows;
            this.Controls.Add(Table);
            int row = 0;

      //      SELECT TOP 1000 [ID]
      //,[TABLENAME]
      //,[FIELDNAME]
      //,[FIELDDESCRIPTION]
      //,[SUMES]
      //,[FIELDTYPE]
      //,[COMBOQUERY]
  //FROM [emp].[dbo].[TABLEFIELDS]

            // FocusedTextBox.FocusedTextBox[] FtextBox = new FocusedTextBox.FocusedTextBox[100];

            DataTable tf = functions.ExecuteSQLQuery("select * from TABLEFIELDS  WHERE (not FIELDDESCRIPTION  IS NULL) AND  TABLENAME='" + f_TableName + "'");

            int ncol = 0;
            int nrow = 0;
            for (int k = 0; k<=tf.Rows.Count - 1; k++)
            {
                // Table.Controls.Add(new Label() { Text = tf.Rows[k]["FIELDDESCRIPTION"].ToString(), Anchor = AnchorStyles.Left, AutoSize = true },ncol, nrow);
                
                string mFieldName = tf.Rows[k]["FIELDNAME"].ToString();
                string ctype = tf.Rows[k]["FIELDTYPE"].ToString();
                int n = 10 * dt.Rows[0][mFieldName].ToString().Length;

                string mQuery = tf.Rows[k]["COMBOQUERY"].ToString();


                if (ctype == "B")
                {

                    //tCombo[k] = new FocusedCombo.FocusedCombo();
                    //tCombo[k].Width = n;
                    //tCombo[k].Text = dt.Rows[0][mFieldName].ToString();
                    //tCombo[k].EnterFocusColor = Color.Yellow;
                    //tCombo[k].Dock = DockStyle.Fill;
                    //functions.FillComboBox(mQuery, tCombo[k]   );

                    //Table.Controls.Add(tCombo[k], ncol + 1, nrow);
                    //tCombo[k].SelectedIndexChanged  += Combo_Changed;
                    //tCombo[k].Tag = (k.ToString() + "   ").Substring(0, 3) + (mFieldName + "                    ").Substring(0, 20) + ctype;  //20 kena

                }
                else   // κείμενο ή αριθμητικό
                {
                    if (n <= 100)
                        n = 100;

                    //t1[k] = new FocusedTextBox.FocusedTextBox();
                    //t1[k].Width = n;
                    //t1[k].Text = dt.Rows[0][mFieldName].ToString();
                    //t1[k].EnterFocusColor = Color.Yellow;
                    //t1[k].Dock = DockStyle.Fill;
                    //Table.Controls.Add(t1[k], ncol + 1, nrow);
                    //t1[k].TextChanged += text_Changed;

                    //// αποθηκεύω στο tag τον αριθμό κ του πίνακα και το όνομα του πεδίου και τον τύπο του
                    //t1[k].Tag = (k.ToString() + "   ").Substring(0, 3) + (mFieldName + "                    ").Substring(0, 20) + ctype;  //20 kena

                }
                   ncol++;
                   ncol++;

                if (ncol > 5)
                {
                    ncol = 0;
                    nrow++;
                }
            }
        }



        //private void Combo_Changed(object sender, EventArgs e)
        //{
        //    ComboBox Temp = default(ComboBox);
        //    Temp = (ComboBox)sender;
        //    // συγκεντρώνω όλα τα textbox που ενημερώθηκαν
        //    nfFieldNames++;
        //    fFieldNames[nfFieldNames] = Temp.Tag.ToString();
        //    fValues[nfFieldNames] = Temp.Text.ToString();  // value


        //}


        //private void text_Changed(object sender, EventArgs e)
        //{
        //    FocusedTextBox.FocusedTextBox Temp = default(FocusedTextBox.FocusedTextBox);
        //    Temp = (FocusedTextBox.FocusedTextBox)sender;
        //    // συγκεντρώνω όλα τα textbox που ενημερώθηκαν
        //    nfFieldNames++;
        //    fFieldNames[nfFieldNames] = Temp.Tag.ToString();
        //    fValues[nfFieldNames] = Temp.Text.ToString();  // value
        //}


        //private void SAVE_Click(object sender, EventArgs e)
        //{

        //    for (int k = 1; k <= nfFieldNames; k++)
        //    {
        //        string fieldname , value ;
        //         // αποθηκεύω στο tag τον αριθμό κ του πίνακα και το όνομα του πεδίου και τον τύπο του
        //         // t1[k].Tag = (k.ToString() + "   ").Substring(0, 3) + (cc + "                    ").Substring(3, 20) + ctype;  //20 kena

        //        fieldname = fFieldNames[k].ToString().Substring(3, 20).Trim();
        //        string FieldType =(fFieldNames[k].ToString()+"   ").Substring(23, 3).Trim();
               
        //         DataTable dt ;
        //        if (FieldType =="C" )
        //               dt = functions.ExecuteSQLQuery("UPDATE  " + f_TableName + " SET  "+fieldname +"='"+fValues[k]+"' WHERE  ID=" + f_ID.ToString());
        //        else if  (FieldType =="B" )
        //            dt = functions.ExecuteSQLQuery("UPDATE  " + f_TableName + " SET  " + fieldname + "=" + fValues[k].Substring(0,3) + " WHERE  ID=" + f_ID.ToString());
        //        else
        //               dt = functions.ExecuteSQLQuery("UPDATE  " + f_TableName + " SET  "+fieldname +"="+fValues[k]+" WHERE  ID=" + f_ID.ToString());
        //    }
        //}























        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
