using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Linq.Expressions;


namespace WindowsFormsApplication1
{
    public partial class QUERY_SETUP : Form
    {
       

       private      string sql1 = null;
           // SELECT ΕΡΟ AS [ΕΠΩΝΥΜΟ],ΕΡΑ ΑS [EPAGGELMA] FROM PEL
         
    private       string sql2 = null;
           // ORDER BY EPO,DIE
    private       string fSQL="";
    private string fsql1 = "";
    private string fsql2 = "";



    private string  FSQLWHERE, FSQLorder;






        private int f_menuid; // Field declaration
        public int f_MENUID // Property declaration

        {
            get { return this.f_menuid; }
            set { this.f_menuid = value; } // Setter declaration
        }

        private string  f_tablename; // Field declaration
        public string f_TableName // Property declaration
        {
            get { return this.f_tablename; }
            set { this.f_tablename = value; } // Setter declaration
        }



        private string f_menuname; // Field declaration
        public string f_MENUNAME // Property declaration
        {
            get { return this.f_menuname; }
            set { this.f_menuname = value; } // Setter declaration
        }




        public QUERY_SETUP()
        {
            InitializeComponent();
        }


//==========================================================================================================
       


        private void tabs_Click(object sender, System.EventArgs e)
        {
            int n  = tabs.TabIndex;
            string c = tabs.SelectedTab.Text;  // tabs.TabPages[n].Text;   //  tabs.SelectedTab.Text +


        }


        #region   πληκτρο ΜΕΤΑΚΙΝΗΣΗ ΠΡΟΣ ΤΑ ΠΑΝΩ

        private void pUp_Click(System.Object sender, System.EventArgs e)
        {
            pano(LSelect, LSelect.SelectedIndex);
        }

        private void oUp_Click_1(object sender, EventArgs e)
        {
            pano(LOrder, LOrder.SelectedIndex);
        }

        private void sUP_Click_1(object sender, EventArgs e)
        {
            pano(LSearch, LSearch.SelectedIndex);
        }



        public void pano(ListBox ll, int curr)
        {
            string c = null;
            int n = 0;
            if (curr<= 0)
                return;
            n = curr;
            c = ll.Items[n - 1].ToString() ;
            // κρατω το περιεχόμενο του πάνω κελιου
            ll.Items[n - 1]  = ll.Items[n].ToString() ;
            ll.Items[n] = c;
            ll.SelectedIndex = n - 1;
        }

        #endregion 

        #region   πληκτρο διαγραφης σειράς
        private void pDel_Click(object sender, EventArgs e)
        {
            deleteItem(LSelect, LSelect.SelectedIndex);
        }


        private void sDelete_Click(object sender, EventArgs e)
        {
            deleteItem(LSearch, LSearch.SelectedIndex);

        }

        private void oDel_Click_1(object sender, EventArgs e)
        {
            deleteItem(LOrder, LOrder.SelectedIndex);
        }
     

        public void deleteItem(ListBox ll, int curr)
        {
            // string c = null;
            int n = 0;
            //If curr = ll.Items.Count - 1 Then Exit Sub
            n = curr;
            if (curr < 0)
            {
                return;
            }

            int k = 0;
            for (k = n; k <= ll.Items.Count - 2; k++)
            {
                // ll.Items(k) = ll.Items(k + 1)
            }

            //c = ll.Items(n + 1)  ' κρατω το περιεχόμενο του πάνω κελιου

            int nL = ll.Items.Count - 1;

            //ll.Items(nL) = " "


            if (n == ll.Items.Count - 1)
            {
                ll.SelectedIndex = n - 1;
            }



            ll.Items.RemoveAt(curr);

            if (curr <= ll.Items.Count - 1)
            {
                ll.SelectedIndex = curr;
            }

            //ll.Items.Clear()
            //For k = n To ll.Items.Count - 2
            //    ll.Items(k) = ll.Items(k + 1)
            //Next


            ll.Refresh();


        }

        #endregion   πληκτρο ΜΕΤΑΚΙΝΗΣΗ ΠΡΟΣ ΤΑ ΠΑΝΩ


        //=====================================================================================================
        #region   πληκτρο μετακινηση προς τα κατω
        private void pDown_Click(object sender, EventArgs e)
        {
            kato(LSelect, LSelect.SelectedIndex);
        }
       //private void sDOWN_Click(object sender, EventArgs e)
       // {
       //     kato(LSearch, LSearch.SelectedIndex);
       //  }
       private void oDown_Click(object sender, EventArgs e)
       {
                kato(LOrder, LOrder.SelectedIndex);
       }

       private void sDOWN_Click(object sender, EventArgs e)
       {
              kato(LSearch, LSearch.SelectedIndex);
       }



       public void kato(ListBox ll, int curr)
       {
        //      Dim c As String, n As Integer
        //If curr = ll.Items.Count - 1 Then Exit Sub
        //If Len(Trim(ll.Items(n + 1))) = 0 Then Exit Sub
           //n = curr
        //c = ll.Items(n + 1)  ' κρατω το περιεχόμενο του πάνω κελιου
        //ll.Items(n + 1) = ll.Items(n)
        //ll.Items(n) = c
        //ll.SelectedIndex = n + 1
           if (curr < 0)
               return;


           string c = null;
           int n = 0;
           if (curr == ll.Items.Count - 1)
               return;
            c = ll.Items[n + 1].ToString() ;
           c=c.Trim();
           if (c.Length == 0)
               return;
           n = curr;
           c = ll.Items[n + 1].ToString() ;
           // κρατω το περιεχόμενο του πάνω κελιου
           ll.Items[n + 1] = ll.Items[n].ToString ();
           ll.Items[n] = c;
           ll.SelectedIndex = n + 1;
       }

       #endregion
       //=====================================================================================================


 #region   SAVE QUERY
       private void SAVE_Click(object sender, EventArgs e)
       {
           int x0=(Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
           int y0 = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
           this.Location = new Point(x0,y0);

           string C = Microsoft.VisualBasic.Interaction.InputBox("Δώστε την περιγραφή του Report", "Prompt", f_MENUNAME,689, 22);
           UPDATE_VARS();
           INSERT_MENU(f_MENUID, C, fsql1, fsql2, fSQL, FSQLWHERE, FSQLorder);
       }


//================================================================
       public void UPDATE_VARS()
       {
             int N = 0;
           string c;
           string sql = null;
           sql1 = " ";
           for (N = 0; N <= LSelect.Items.Count - 1; N++)
           {
               sql1 = sql1 + (N == 0 ? "" : ",") ;
                     c=LSelect.Items[N].ToString()  ;
                     c=c.Substring ( 200, 20) ;
                     sql1=sql1+ c.Trim() ;
                     c = LSelect.Items[N].ToString();
                     c = c.Substring(0, 100);
                     sql1=sql1+ " AS [" + c.Trim() + "]";
             
               fSQL = fSQL + (N == 0 ? "" : Globals.gSplitter) + LSelect.Items[N].ToString();
           }
           sql1 = "select  ID, " + (sql1.Trim().Length  == 0 ? "*" : sql1) + "  from " + f_TableName;
           FSQLorder = "";
           sql2 = "";
           for (N = 0; N <= LOrder.Items.Count - 1; N++)
           {
               sql2 = sql2 + (N == 0 ? " ORDER BY " : ",") +  LOrder.Items[N].ToString().Substring( 200, 20).Trim() ;
               FSQLorder = FSQLorder + (N == 0 ? "" : Globals.gSplitter) + LOrder.Items[N].ToString();
           }
           FSQLWHERE = "";
           for (N = 0; N <= LSearch.Items.Count - 1; N++)
           {
               FSQLWHERE = FSQLWHERE + (N == 0 ? "" : Globals.gSplitter) + LSearch.Items[N].ToString();
           }
           sql = sql1 + sql2;
           Label1.Text = sql;
           fsql1 = sql1;
           fsql2 = sql2;
       }


       public void INSERT_MENU(int menuID, string menutext, string sql1, string sql2, string sqlSelect, string sqlWhere, string sqlOrder)
       {
           functions.ExecuteSQLQuery("DELETE FROM NEWMENUS WHERE MENUNAME='" + menutext + "'");
           string SQL = null;
           string CmenuID = menuID.ToString();
           SQL = "INSERT INTO [dbo].[NEWMENUS] " + "([MENU_ID] " + ",[PARENT_ID] " + ",[SQL1] " + ",[SQL2] " + ",[MENUNAME] " + ",[TSQLSELECT] " + ",[TSQLWHERE] " + ",[TSQLORDER] )" + "VALUES " + "(" + CmenuID + ",0 " + ",'" + sql1 + "'" + ",'" + sql2 + "'" + ",'" + menutext + "'" + ",'" + sqlSelect + "'" + ",'" + sqlWhere + "'" + ",'" + sqlOrder + "')";
           try
           {
               functions.ExecuteSQLQuery(SQL);
               MessageBox.Show("ΟΚ");
           }
           catch (Exception ex)
           {
               MessageBox.Show("ΔΕΝ ΑΠΟΘΗΚΕΥΤΗΚΕ");
           }
       }

 #endregion

        // φορτώνω τα πεδία 
        private void QUERY_SETUP_Load(System.Object sender, System.EventArgs e)
        {
            DataTable dt = new System.Data.DataTable();
            dt = functions.ExecuteSQLQuery("select * from  TABLEFIELDS WHERE TABLENAME='" + f_TableName + "' and  NOT (FIELDDESCRIPTION is NULL)");
            // int n = 0;
            string c = null;
            string cc = null;
            string space200 = new string(' ', 200);
            string space100 = new string(' ', 100);
            string space20 = new string(' ', 20);
            string space10 = new string(' ', 10);

              foreach (DataRow dr in dt.Rows)
          //  for (n = 0; n <= Globals.sqlDT.Rows.Count - 1; n++)
            {
                cc =" "+  dr["FIELDDESCRIPTION"].ToString()+space200+" ";
                c = cc.Substring (0,200);   //  + Strings.Space(200), 1, 200);
                cc = dr["FIELDNAME"].ToString() + space20 + " ";
                c = c + cc.Substring(0, 20);
                  // c = c + Mid(dt.Rows(n)("FIELDTYPE") + Space(10), 1, 10)
                cc = dr["FIELDTYPE"].ToString() + space10 + " ";
                c = c + cc.Substring(0, 10);                  
                  cc = dr["COMBOQUERY"].ToString() + space100 + " ";

                  cc.Replace("'", "~");

                c = c + cc.Substring(0, 100);
                LFields.Items.Add(c);
            }
        }
        // For n = 0 To dt.Rows.Count - 1
        //    c = Mid(dt.Rows(n)("FIELDDESCRIPTION").ToString + Space(200), 1, 200)
        //    c = c + Mid(dt.Rows(n)("FIELDNAME") + Space(20), 1, 20)
        //    c = c + Mid(dt.Rows(n)("FIELDTYPE") + Space(10), 1, 10)
        //    c = c + Mid(dt.Rows(n)("COMBOQUERY") + Space(100), 1, 100)

        //    LFields.Items.Add(c)
        //    'ChildForm.LFields.Items.Add(dt.Columns(n).Caption)
        //Next
// γεμιζω τα listboxes
        private void LFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c = tabs.TabPages[0].Text;
            int i;
            // ΓΕΜΙΖΩ ΤΑ ΠΕΔΙΑ ΠΟΥ ΘΑ ΤΥΠΩΘΟΥΝ  LSelect  Listbox
            if (tabs.SelectedTab.Text == c)
            {
                i = LFields.SelectedIndex;
                if (i >= 0)
                {
                    c = LFields.Items[i].ToString();
                    LSelect.Items.Add(c);
                }
            }

            //search    ΓΕΜΙΖΩ ΤΑ ΠΕΔΙΑ ΠΟΥ ΘΑ ΤΥΠΩΘΟΥΝ  LSearch  Listbox
            c = tabs.TabPages[1].Text;
            if (tabs.SelectedTab.Text == c)
            {

                i = LFields.SelectedIndex;
                if (i >= 0)
                {
                    c = LFields.Items[i].ToString();
                    LSearch.Items.Add(c);
                }
            }


            //order     ΓΕΜΙΖΩ ΤΑ ΠΕΔΙΑ ΠΟΥ ΘΑ ΤΥΠΩΘΟΥΝ  LOrder  Listbox
            c = tabs.TabPages[2].Text;
            if (tabs.SelectedTab.Text == c)
            {
                i = LFields.SelectedIndex;
                if (i >=0)
                   {
                    c = LFields.Items[i].ToString();
                    LOrder.Items.Add(c);
                    }
            }
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            if (f_MENUNAME.Trim().Length  > 0)   // Strings.Len(Strings.Trim
            {
                DataTable dt=functions.ExecuteSQLQuery("DELETE FROM NEWMENUS WHERE MENUNAME='" + f_MENUNAME + "'");
                if (dt.Rows.Count >0 )
                MessageBox.Show("διεγράφη");

            }           
        }

       

      
        
        
        

       
        //========================================================================================================
    }

//    VB             C#

//UBound()     = yourArray.GetUpperBound(0) or yourArray.Length for one-dimesional arrays
//LBound()     = yourArray.GetLowerBound(0)
//IsNothing()  = Object.ReferenceEquals(obj,null)
//Chr()        = Convert.ToChar()
//Len()        = "string".Length
//UCase()      = "string".ToUpper()
//LCase()      = "string".ToLower()
//Left()       = "string".Substring(0, length)
//Right()      = "string".Substring("string".Length - desiredLength)
//RTrim()      = "string".TrimEnd()
//LTrim()      = "string".TrimStart()
//Trim()       = "string".Trim()
//Mid()        = "string".Substring(start, length)
//Replace()    = "string".Replace()
//Split()      = "string".Split()
//Join()       = String.Join()
//MsgBox()     = MessageBox.Show()
//IIF()        = (boolean_condition ? "true" : "false")



}
